SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

DELIMITER $$
--
-- Yordamlar
--
CREATE DEFINER=`cpses_allrwac1ij`@`localhost` PROCEDURE `addOrUpdateClass` (IN `_classID` INT, IN `_className` VARCHAR(45), IN `_classHours` INT)  BEGIN
	IF _classID = 0 THEN
		INSERT INTO class (className, classHours) VALUES (_className, _classHours);
	ELSE
		UPDATE class SET
			className = _className,
			classHours = _classHours
		WHERE classID = _classID;
	END IF;
END$$

CREATE DEFINER=`cpses_allrwac1ij`@`localhost` PROCEDURE `addOrUpdateCourse` (IN `_courseID` INT, IN `_courseName` VARCHAR(50), IN `_courseWeeks` INT, IN `_price` INT, IN `_courseBeg` CHAR(30))  BEGIN
	IF _courseID = 0 THEN
		INSERT INTO course (courseName, courseWeeks, price, courseBeg) 
        VALUES (_courseName, _courseWeeks, _price, STR_TO_DATE(_courseBeg, '%d - %m - %Y'));
    ELSE
		UPDATE course SET
			courseName = _courseName,
            courseWeeks = _courseWeeks,
            price = _price,
            courseBeg = STR_TO_DATE(_courseBeg, '%d - %m - %Y')
		WHERE courseID = _courseID;
    END IF;
END$$

CREATE DEFINER=`cpses_allrwac1ij`@`localhost` PROCEDURE `addOrUpdatePerson` (IN `_nickname` VARCHAR(20), IN `_password` VARCHAR(10), IN `_fname` VARCHAR(45), IN `_lname` VARCHAR(45), IN `_mobilePhone` VARCHAR(45), IN `_homePhone` VARCHAR(45), IN `_address` VARCHAR(200), IN `_email` VARCHAR(45), IN `_isTeacher` BOOLEAN)  BEGIN
	IF NOT EXISTS (SELECT * FROM person WHERE nickname = _nickname) THEN
		INSERT INTO person 
        VALUES (_nickname, _password, _fname, _lname, _mobilePhone, _homePhone, _address, _email, _isTeacher);
    ELSE
		UPDATE person SET
			nickname = _nickname,
            password = _password,
            fname = _fname,
            lname = _lname,
            mobilePhone = _mobilePhone,
            homePhone = _homePhone,
            address = _address,
            email = _email,
            isTeacher = _isTeacher
        WHERE nickname = _nickname;
    END IF;
END$$

CREATE DEFINER=`cpses_allrwac1ij`@`localhost` PROCEDURE `deleteClass` (IN `_classID` INT)  BEGIN
	DELETE FROM class WHERE classID = _classID;
END$$

CREATE DEFINER=`cpses_allrwac1ij`@`localhost` PROCEDURE `deleteCourse` (IN `_courseID` INT)  BEGIN
	DELETE FROM course WHERE courseID = _courseID;
END$$

CREATE DEFINER=`cpses_allrwac1ij`@`localhost` PROCEDURE `deletePerson` (IN `_nickname` VARCHAR(20))  BEGIN
	DELETE FROM person WHERE nickname = _nickname;
END$$

CREATE DEFINER=`cpses_allrwac1ij`@`localhost` PROCEDURE `getPerson` (IN `_nickname` VARCHAR(20))  BEGIN
	SELECT fname, lname, mobilePhone, homePhone, email, address, password 
    FROM person WHERE _nickname = nickname;
END$$

CREATE DEFINER=`cpses_allrwac1ij`@`localhost` PROCEDURE `searchClass` (IN `_searchValue` VARCHAR(50))  BEGIN
	SELECT classID, className AS 'Ders Ismi', classHours AS 'Ders Suresi (saat)' FROM class 
    WHERE className LIKE CONCAT('%', _searchValue, '%');
END$$

CREATE DEFINER=`cpses_allrwac1ij`@`localhost` PROCEDURE `searchCourse` (IN `_searchValue` VARCHAR(50))  BEGIN
	SELECT courseID, courseName AS 'Kurs Ismi', price AS 'Fiyat (TL)', courseBeg AS 'Baslangic Tarihi', 
    courseWeeks AS 'Kurs Suresi (hafta)' FROM course 
    WHERE courseName LIKE CONCAT('%', _searchValue, '%');
END$$

CREATE DEFINER=`cpses_allrwac1ij`@`localhost` PROCEDURE `searchPerson` (IN `_searchValue` VARCHAR(50), IN `_isTeacher` BOOLEAN)  BEGIN
	SELECT fname AS 'Isim', lname AS 'Soyisim', mobilePhone AS 'Cep Tel.', homePhone, email AS 'E-Mail', 
    address, nickname, password FROM person WHERE isTeacher = _isTeacher AND 
    (fname LIKE CONCAT('%', _searchValue, '%') OR lname LIKE CONCAT('%', _searchValue, '%') OR
    nickname LIKE CONCAT('%', _searchValue, '%') OR email LIKE CONCAT('%', _searchValue, '%'));
END$$

CREATE DEFINER=`cpses_allrwac1ij`@`localhost` PROCEDURE `updateCourseClass` (`_courseID` INT, `_classID` INT, `_teacherNickname` VARCHAR(20), `addOrNot` BOOL)  BEGIN
	IF addOrNot = true AND isCourseClass(_courseID, _classID, _teacherNickname) = false THEN
		INSERT INTO course_classes VALUES (_courseID, _classID, _teacherNickname);
	ELSEIF addOrNot = false AND isCourseClass(_courseID, _classID, _teacherNickname) = true THEN
		DELETE FROM course_classes WHERE courseID = _courseID AND classID = _classID AND teacherNickname = _teacherNickname;		
    END IF;
END$$

CREATE DEFINER=`cpses_allrwac1ij`@`localhost` PROCEDURE `updateStudentCourse` (`_courseID` INT, `_studentNickname` VARCHAR(20), `_price` INT, `addOrNot` BOOL)  BEGIN
	IF addOrNot = true AND isStudentCourse(_courseID, _studentNickname) = false THEN
		INSERT INTO student_courses VALUES (_courseID, _studentNickname, _price);
	ELSEIF addOrNot = false AND isStudentCourse(_courseID, _studentNickname) = true THEN
		DELETE FROM student_courses WHERE courseID = _courseID AND studentNickname = _studentNickname;		
    END IF;
END$$

CREATE DEFINER=`cpses_allrwac1ij`@`localhost` PROCEDURE `updateTeacherClass` (`_classID` INT, `_teacherNickname` VARCHAR(20), `addOrNot` BOOL)  BEGIN
	IF addOrNot = true AND isTeacherClass(_classID, _teacherNickname) = false THEN
		INSERT INTO teacher_classes VALUES (_classID, _teacherNickname);
	ELSEIF addOrNot = false AND isTeacherClass(_classID, _teacherNickname) = true THEN
		DELETE FROM teacher_classes WHERE classID = _classID AND teacherNickname = _teacherNickname;		
    END IF;
END$$

CREATE DEFINER=`cpses_allrwac1ij`@`localhost` PROCEDURE `viewClasses` ()  BEGIN
	SELECT classID, className AS 'Ders Ismi', classHours AS 'Ders Suresi (saat)' FROM class ORDER BY className;
END$$

CREATE DEFINER=`cpses_allrwac1ij`@`localhost` PROCEDURE `viewCourses` ()  BEGIN
	SELECT courseID, courseName AS 'Kurs Ismi', price AS 'Fiyat (TL)', courseBeg AS 'Baslangic Tarihi', 
    courseWeeks AS 'Kurs Suresi (hafta)' FROM course ORDER BY courseName;
END$$

CREATE DEFINER=`cpses_allrwac1ij`@`localhost` PROCEDURE `viewPersons` (IN `_isTeacher` BOOLEAN)  BEGIN
	SELECT fname AS 'Isim', lname AS 'Soyisim', mobilePhone AS 'Cep Tel.', homePhone, email AS 'E-Mail', 
	address, nickname, password FROM person WHERE _isTeacher = isTeacher ORDER BY CONCAT(fname, lname);
END$$

CREATE DEFINER=`cpses_allrwac1ij`@`localhost` PROCEDURE `viewTeacherClasses` ()  BEGIN
	SELECT c.classID, p.nickname, c.className AS 'Ders Ismi', c.classHours
    AS 'Ders Suresi (saat)', CONCAT(p.fname, " ", p.lname) AS 'Ogretmen' FROM class c, teacher_classes t, person p 
    WHERE c.classID = t.classID AND p.nickname = t.teacherNickname ORDER BY c.className;
END$$

--
-- İşlevler
--
$$

$$

$$

$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `class`
--

CREATE TABLE `class` (
  `classID` int(11) NOT NULL,
  `className` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `classHours` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Tablo döküm verisi `class`
--

INSERT INTO `class` (`classID`, `className`, `classHours`) VALUES
(19, 'Ahsap Boyama', 3),
(20, 'Vitray', 3),
(21, 'Tahta Oymacilik', 2),
(22, 'Rölyef', 3),
(23, 'Seramik', 2),
(24, 'Yagli Boya', 2),
(25, 'Soyut Resim', 3),
(26, 'Heykel', 2),
(27, 'Dikis', 4),
(28, 'Karakalem', 3),
(30, 'Ders', 5);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `course`
--

CREATE TABLE `course` (
  `courseID` int(11) NOT NULL,
  `courseName` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `courseWeeks` int(11) NOT NULL,
  `courseBeg` date NOT NULL,
  `price` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Tablo döküm verisi `course`
--

INSERT INTO `course` (`courseID`, `courseName`, `courseWeeks`, `courseBeg`, `price`) VALUES
(11, 'Resim Kursu', 10, '2019-05-13', 5000),
(12, 'Kurs Paketi - 1', 15, '2019-05-18', 7500),
(13, 'Kurs Paketi - 2', 12, '2019-05-18', 6000),
(14, 'Kurs', 15, '2019-08-16', 8000);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `course_classes`
--

CREATE TABLE `course_classes` (
  `courseID` int(11) NOT NULL,
  `classID` int(11) NOT NULL,
  `teacherNickname` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Tablo döküm verisi `course_classes`
--

INSERT INTO `course_classes` (`courseID`, `classID`, `teacherNickname`) VALUES
(11, 19, 'martin'),
(11, 25, 'ustura'),
(11, 28, 'tolk'),
(12, 20, 'tolk'),
(12, 21, 'ustura'),
(12, 27, 'tolk'),
(12, 28, 'tolk'),
(13, 22, 'tolk'),
(13, 25, 'martin'),
(13, 27, 'tolk'),
(14, 22, 'tolk'),
(14, 25, 'martin'),
(14, 28, 'tolk');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `person`
--

CREATE TABLE `person` (
  `nickname` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `password` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `fname` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `lname` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `mobilePhone` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `homePhone` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `address` varchar(250) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `email` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `isTeacher` tinyint(4) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Tablo döküm verisi `person`
--

INSERT INTO `person` (`nickname`, `password`, `fname`, `lname`, `mobilePhone`, `homePhone`, `address`, `email`, `isTeacher`) VALUES
('abcd', '1234', 'Abc', 'Def', '', '', '', '', 1),
('king', '666', 'Night', 'King', '456789', '456789', 'Westeros', 'night@walker.com', 0),
('martin', '4321', 'George R. R.', 'Martin', '123456789', '987654321', 'USA', 'martin@george.com', 1),
('ned', '12345', 'Eddard', 'Stark', '123456', '654321', 'Winterfell', 'ned@stark.com', 0),
('severus', 'snape', 'Severus', 'Snape', '644861', '4654651', 'Hogwarts', 'severus@snape.com', 0),
('tolk', 'ien', 'J. R. R.', 'Tolkien', '5514502986', '553665412', 'Shire', 'cRaZY_tolkien@hotmail.com', 1),
('tom', 'riddle', 'Lord', 'Voldemort', '789878', '987456', 'Hogwarts', 'lord@volde.mort', 0),
('ustura', '123456', 'Ursula K. Le', 'Guin', '987654321', '123456789', 'mezarlık', 'ursula@mynet.com', 1);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `student_courses`
--

CREATE TABLE `student_courses` (
  `courseID` int(11) NOT NULL,
  `studentNickname` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `price` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Tablo döküm verisi `student_courses`
--

INSERT INTO `student_courses` (`courseID`, `studentNickname`, `price`) VALUES
(11, 'king', 5000),
(11, 'ned', 5000),
(12, 'king', 7500),
(12, 'severus', 7500),
(12, 'tom', 7500),
(13, 'king', 6000),
(13, 'ned', 6000),
(14, 'king', 8000);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `teacher_classes`
--

CREATE TABLE `teacher_classes` (
  `classID` int(11) NOT NULL,
  `teacherNickname` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Tablo döküm verisi `teacher_classes`
--

INSERT INTO `teacher_classes` (`classID`, `teacherNickname`) VALUES
(19, 'martin'),
(20, 'martin'),
(20, 'tolk'),
(21, 'martin'),
(21, 'ustura'),
(22, 'abcd'),
(22, 'tolk'),
(22, 'ustura'),
(23, 'ustura'),
(25, 'martin'),
(25, 'ustura'),
(26, 'abcd'),
(26, 'tolk'),
(27, 'tolk'),
(28, 'abcd'),
(28, 'martin'),
(28, 'tolk');

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `class`
--
ALTER TABLE `class`
  ADD PRIMARY KEY (`classID`);

--
-- Tablo için indeksler `course`
--
ALTER TABLE `course`
  ADD PRIMARY KEY (`courseID`);

--
-- Tablo için indeksler `course_classes`
--
ALTER TABLE `course_classes`
  ADD PRIMARY KEY (`courseID`,`classID`,`teacherNickname`),
  ADD KEY `course_classes_courseFK_idx` (`courseID`),
  ADD KEY `courseClasses_classFK_idx` (`classID`),
  ADD KEY `courseClasses_nicknameFK_idx` (`teacherNickname`);

--
-- Tablo için indeksler `person`
--
ALTER TABLE `person`
  ADD PRIMARY KEY (`nickname`);

--
-- Tablo için indeksler `student_courses`
--
ALTER TABLE `student_courses`
  ADD PRIMARY KEY (`courseID`,`studentNickname`),
  ADD KEY `student_course_studentFK_idx` (`studentNickname`);

--
-- Tablo için indeksler `teacher_classes`
--
ALTER TABLE `teacher_classes`
  ADD PRIMARY KEY (`classID`,`teacherNickname`),
  ADD KEY `teacherClasses_nicknameFK_idx` (`teacherNickname`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `class`
--
ALTER TABLE `class`
  MODIFY `classID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

--
-- Tablo için AUTO_INCREMENT değeri `course`
--
ALTER TABLE `course`
  MODIFY `courseID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- Dökümü yapılmış tablolar için kısıtlamalar
--

--
-- Tablo kısıtlamaları `course_classes`
--
ALTER TABLE `course_classes`
  ADD CONSTRAINT `courseClasses_classFK` FOREIGN KEY (`classID`) REFERENCES `class` (`classID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `courseClasses_courseFK` FOREIGN KEY (`courseID`) REFERENCES `course` (`courseID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `courseClasses_nicknameFK` FOREIGN KEY (`teacherNickname`) REFERENCES `person` (`nickname`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Tablo kısıtlamaları `student_courses`
--
ALTER TABLE `student_courses`
  ADD CONSTRAINT `student_course_courseFK` FOREIGN KEY (`courseID`) REFERENCES `course` (`courseID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `student_course_studentFK` FOREIGN KEY (`studentNickname`) REFERENCES `person` (`nickname`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Tablo kısıtlamaları `teacher_classes`
--
ALTER TABLE `teacher_classes`
  ADD CONSTRAINT `teacherClasses_classFK` FOREIGN KEY (`classID`) REFERENCES `class` (`classID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `teacherClasses_nicknameFK` FOREIGN KEY (`teacherNickname`) REFERENCES `person` (`nickname`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
