-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 14, 2024 at 08:32 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `tcc_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `AdminID` int(11) NOT NULL,
  `UserID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `adminrequests`
--

CREATE TABLE `adminrequests` (
  `AdminRequestID` int(11) NOT NULL,
  `UserID` int(11) NOT NULL,
  `RequestDescription` varchar(255) DEFAULT NULL,
  `RequestTime` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `adminrequests`
--

INSERT INTO `adminrequests` (`AdminRequestID`, `UserID`, `RequestDescription`, `RequestTime`) VALUES
(1, 201, 'Requesting a password reset due to account access issues', '2024-12-14 14:34:10'),
(2, 202, 'Requesting to change email address', '2024-12-14 14:34:10'),
(3, 203, 'Requesting to update profile picture', '2024-12-14 14:34:10'),
(4, 204, 'Requesting to deactivate account', '2024-12-14 14:34:10'),
(5, 205, 'Requesting assistance with a failed login attempt', '2024-12-14 14:34:10'),
(6, 206, 'Requesting access to premium features', '2024-12-14 14:34:10'),
(7, 207, 'Requesting to change user role from user to admin', '2024-12-14 14:34:10'),
(8, 208, 'Requesting to restore previous session data', '2024-12-14 14:34:10'),
(9, 209, 'Requesting to update the personal contact information', '2024-12-14 14:34:10'),
(10, 210, 'Requesting a refund for an erroneous charge', '2024-12-14 14:34:10'),
(11, 211, 'Requesting to delete my account', '2024-12-14 14:34:10'),
(12, 212, 'Requesting a new password due to account lock', '2024-12-14 14:34:10'),
(13, 213, 'Requesting assistance with updating payment information', '2024-12-14 14:34:10'),
(14, 214, 'Requesting to join a special user group', '2024-12-14 14:34:10'),
(15, 215, 'Requesting support with two-factor authentication setup', '2024-12-14 14:34:10');

-- --------------------------------------------------------

--
-- Table structure for table `area`
--

CREATE TABLE `area` (
  `AreaID` int(11) NOT NULL,
  `AreaName` varchar(50) NOT NULL,
  `MaxCapacity` int(11) NOT NULL DEFAULT 150,
  `UtilisationType` varchar(50) NOT NULL DEFAULT 'Creative Workspace',
  `UsageStatistic` int(11) NOT NULL DEFAULT 0,
  `UnderutilisationFlag` tinyint(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `areaattendance`
--

CREATE TABLE `areaattendance` (
  `AreaAttendanceID` int(11) NOT NULL,
  `AreaID` int(11) NOT NULL,
  `Date` datetime NOT NULL DEFAULT current_timestamp(),
  `Attendance` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `engagementactivity`
--

CREATE TABLE `engagementactivity` (
  `ActivityID` int(11) NOT NULL,
  `EngagementID` int(11) NOT NULL,
  `EngagementType` varchar(50) DEFAULT NULL,
  `InteractionTime` datetime NOT NULL DEFAULT current_timestamp(),
  `PlatformType` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `event`
--

CREATE TABLE `event` (
  `EventID` int(11) NOT NULL,
  `EventName` varchar(50) NOT NULL,
  `EventType` varchar(1000) DEFAULT NULL,
  `Attendance` int(11) NOT NULL DEFAULT 0,
  `MaxCapacity` int(11) NOT NULL DEFAULT 150,
  `EventDate` datetime DEFAULT NULL,
  `TagID` int(11) NOT NULL,
  `Location` varchar(50) DEFAULT NULL,
  `BannerImageAddress` varchar(255) DEFAULT NULL,
  `EventSiteLink` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `event`
--

INSERT INTO `event` (`EventID`, `EventName`, `EventType`, `Attendance`, `MaxCapacity`, `EventDate`, `TagID`, `Location`, `BannerImageAddress`, `EventSiteLink`) VALUES
(1, 'Writers Retreat', 'Step away from the chaos and spend a weekend focused on your writing. Together Culture\'s Writer Retreat offers a relaxed setting to work on your projects, meet other writers, and pick up new ideas through workshops and casual discussions. Whether fine-tuning a draft or starting fresh, this is your chance to focus, learn, and share in a laid-back, supportive environment.', 10, 15, '2024-12-20 08:00:00', 101, 'Fitzoy Street', 'https://images.pexels.com/photos/834897/pexels-photo-834897.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1', 'https://example.com/writers'),
(2, 'Album Listen', 'Join us for a group album listening experience like no other. Sit back and vibe as we dive into a handpicked album, taking in every lyric, beat, and story it tells. Whether you\'re discovering new music or revisiting a classic, this is the perfect space to share thoughts, discuss themes, and connect with others who love music just as much as you do. Come for the tunes, stay for the conversation.\n', 30, 50, '2024-12-25 10:00:00', 102, 'Fitzroy Street', 'https://st.depositphotos.com/2859315/4182/v/950/depositphotos_41824719-stock-illustration-retro-vintage-vector-vinyl-record.jpg', 'https://example.com/album'),
(3, 'Art Showcase', 'Visiting an exhibition nearby the Together Culture building which features artwork created by many Together Culture Members', 80, 100, '2024-12-18 00:00:00', 103, 'Newmarket Street', 'https://www.jimrabby.com/wp-content/uploads/2015/05/GalleryInterior1.jpg', 'https://example.com/art-expo'),
(4, 'Business Meet', 'Networking event for people of all disciplines. Come and make new friends, grab a coffee and mingle!', 20, 25, '2025-01-15 00:00:00', 104, 'Cafe Near ARU', 'https://images.pexels.com/photos/1015568/pexels-photo-1015568.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1', 'https://example.com/business-meetup'),
(5, 'Health & Wellness Fair', 'Join us for a group album listening experience like no other. Sit back and vibe as we dive into a handpicked album, taking in every lyric, beat, and story it tells. Whether you\'re discovering new music or revisiting a classic, this is the perfect space to share thoughts, discuss themes, and connect with others who love music just as much as you do. Come for the tunes, stay for the conversation.\n', 200, 250, '2025-02-10 00:00:00', 105, 'Parkers Piece', 'https://images.pexels.com/photos/8940023/pexels-photo-8940023.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1', 'https://example.com/health-fair'),
(6, 'Hackathon', '24 Hour Hackathon to test your programming knowledge! Learn and collaborate with likeminded people to deliver a final product and compete against other applications!', 30, 50, '2025-03-05 00:00:00', 106, 'Fitzroy Street', 'https://images.pexels.com/photos/1181677/pexels-photo-1181677.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1', 'https://example.com/hackathon'),
(7, 'Culture Fest', 'Celebrating all different cultures!', 400, 450, '2025-04-01 00:00:00', 107, 'Jesus Green', 'https://images.pexels.com/photos/1186116/pexels-photo-1186116.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1', 'https://example.com/cultural-fest'),
(8, 'Convention', 'Visiting a large convention in London!', 40, 40, '2025-05-12 00:00:00', 108, 'London', 'https://images.pexels.com/photos/167478/pexels-photo-167478.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1', 'https://example.com/convention'),
(9, 'DIY Crafting Night', 'A fun, hands-on event where participants can learn how to make unique crafts such as candles, pottery, or jewelry, while enjoying good company.', 150, 200, '2025-06-20 00:00:00', 109, 'Together Culture Workspace', 'https://images.pexels.com/photos/301703/pexels-photo-301703.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1', 'https://example.com/diy'),
(10, 'Startup Pitch Night', 'Got an idea that could change the game? Join us for Together Culture\'s Startup Pitch Night, where budding entrepreneurs get the chance to present their ideas to a room full of like-minded innovators, investors, and industry professionals. Whether you’re launching a new product, service, or tech solution, this is your opportunity to pitch, network, and get feedback. It\'s a great way to test your ideas, gain insights, and make valuable connections that could help bring your vision to life.', 10, 15, '2025-07-15 00:00:00', 110, 'Fitzroy Street', 'https://images.pexels.com/photos/29708266/pexels-photo-29708266/free-photo-of-speaker-at-a-business-conference-event.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1', 'https://example.com/startup-pitch-night'),
(11, 'Music Concert', 'Concert', 0, 150, '2024-12-01 19:00:00', 1, 'Main Hall', 'path/to/banner.jpg', 'http://eventlink.com'),
(12, 'Art Exhibition', 'Exhibition', 0, 100, '2024-12-02 10:00:00', 2, 'Art Gallery', 'path/to/banner2.jpg', 'http://artlink.com'),
(13, 'Tech Meetup', 'Meetup', 0, 50, '2024-12-03 14:30:00', 3, 'Conference Room', 'path/to/banner3.jpg', 'http://techlink.com'),
(14, 'Charity Auction', 'Auction', 0, 200, '2024-12-04 17:00:00', 4, 'Banquet Hall', 'path/to/banner4.jpg', 'http://auctionlink.com'),
(15, 'Book Launch', 'Launch', 0, 50, '2024-12-05 16:00:00', 5, 'Library Hall', 'path/to/banner5.jpg', 'http://booklink.com');

-- --------------------------------------------------------

--
-- Table structure for table `eventbooking`
--

CREATE TABLE `eventbooking` (
  `BookingID` int(11) NOT NULL,
  `EventID` int(11) NOT NULL,
  `BookingDate` datetime NOT NULL DEFAULT current_timestamp(),
  `UserID` int(11) NOT NULL,
  `AttendanceStatus` tinyint(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `eventbooking`
--

INSERT INTO `eventbooking` (`BookingID`, `EventID`, `BookingDate`, `UserID`, `AttendanceStatus`) VALUES
(101, 1, '2024-12-01 09:30:00', 201, 1),
(102, 2, '2024-12-02 10:00:00', 202, 0),
(103, 3, '2024-12-03 14:15:00', 203, 1),
(104, 4, '2024-12-04 16:45:00', 204, 1),
(105, 5, '2024-12-05 12:30:00', 205, 0);

-- --------------------------------------------------------

--
-- Table structure for table `feedback`
--

CREATE TABLE `feedback` (
  `FeedbackID` int(11) NOT NULL,
  `BookingID` int(11) NOT NULL,
  `FeedbackScore` int(11) NOT NULL DEFAULT 500,
  `FeedbackText` varchar(100) DEFAULT NULL,
  `UserID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `feedback`
--

INSERT INTO `feedback` (`FeedbackID`, `BookingID`, `FeedbackScore`, `FeedbackText`, `UserID`) VALUES
(1, 101, 500, 'Great service! Highly satisfied.', 1),
(2, 102, 450, 'Good experience, but room for improvement.', 2),
(3, 103, 400, 'Average service. Could have been better.', 3),
(4, 104, 350, 'Service was okay, but delays were frustrating.', 4),
(5, 105, 300, 'Not satisfied. Encountered multiple issues.', 5);

-- --------------------------------------------------------

--
-- Table structure for table `interesttag`
--

CREATE TABLE `interesttag` (
  `TagID` int(11) NOT NULL,
  `TagName` varchar(50) NOT NULL,
  `TagCreationDate` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `interesttag`
--

INSERT INTO `interesttag` (`TagID`, `TagName`, `TagCreationDate`) VALUES
(1, 'Music', '2024-12-14 14:18:58'),
(2, 'Art', '2024-12-14 14:18:58'),
(3, 'Technology', '2024-12-14 14:18:58'),
(4, 'Charity', '2024-12-14 14:18:58'),
(5, 'Literature', '2024-12-14 14:18:58'),
(101, 'Technology', '2024-12-14 00:48:16'),
(102, 'Music', '2024-12-14 00:48:16'),
(103, 'Art', '2024-12-14 00:48:16'),
(104, 'Business', '2024-12-14 00:48:16'),
(105, 'Health', '2024-12-14 00:48:16'),
(106, 'Coding', '2024-12-14 00:48:16'),
(107, 'Culture', '2024-12-14 00:48:16'),


-- --------------------------------------------------------

--
-- Table structure for table `keyvalue`
--

CREATE TABLE `keyvalue` (
  `ValueID` int(11) NOT NULL,
  `KeyValueName` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `mailinglistsubscription`
--

CREATE TABLE `mailinglistsubscription` (
  `SubscriptionID` int(11) NOT NULL,
  `UserID` int(11) NOT NULL,
  `SubscriptionDate` datetime NOT NULL DEFAULT current_timestamp(),
  `IsActive` tinyint(1) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `member`
--

CREATE TABLE `member` (
  `MemberID` int(11) NOT NULL,
  `MembershipTypeID` int(11) NOT NULL,
  `UserID` int(11) NOT NULL,
  `SegmentID` int(11) NOT NULL,
  `StartDate` datetime NOT NULL DEFAULT current_timestamp(),
  `EndDate` datetime DEFAULT NULL,
  `LastSpaceVisitDate` datetime DEFAULT NULL,
  `LastInteractionDate` datetime DEFAULT NULL,
  `StudentOrganisation` varchar(100) DEFAULT NULL,
  `ValueID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `membershipbenefits`
--

CREATE TABLE `membershipbenefits` (
  `MembershipBenefitsID` int(11) NOT NULL,
  `Description` varchar(250) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `membershiptype`
--

CREATE TABLE `membershiptype` (
  `MembershipTypeID` int(11) NOT NULL,
  `TypeName` varchar(30) NOT NULL,
  `Description` varchar(100) DEFAULT NULL,
  `Cost` float NOT NULL DEFAULT 0,
  `Duration` varchar(10) NOT NULL DEFAULT 'DAY',
  `JoiningFee` int(11) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `membershiptypebenefits`
--

CREATE TABLE `membershiptypebenefits` (
  `MembershipTypeID` int(11) NOT NULL,
  `MembershipBenefitsID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `payment`
--

CREATE TABLE `payment` (
  `PaymentID` int(11) NOT NULL,
  `PaymentDate` datetime NOT NULL DEFAULT current_timestamp(),
  `UserID` int(11) NOT NULL,
  `Purpose` varchar(50) DEFAULT NULL,
  `Amount` float NOT NULL DEFAULT 0,
  `PaymentMethod` enum('cash','card') NOT NULL DEFAULT 'card',
  `Status` enum('Successful','Unsuccessful') NOT NULL DEFAULT 'Successful',
  `BookingID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `potentialmember`
--

CREATE TABLE `potentialmember` (
  `PotentialMemberID` int(11) NOT NULL,
  `UserID` int(11) NOT NULL,
  `DateOfFirstInteraction` datetime NOT NULL DEFAULT current_timestamp(),
  `SegmentID` int(11) NOT NULL,
  `DateOfConversion` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `preferences`
--

CREATE TABLE `preferences` (
  `PreferenceID` int(11) NOT NULL,
  `MemberID` int(11) NOT NULL,
  `NotificationPreference` enum('off','on') NOT NULL DEFAULT 'on',
  `PreferredContactMethod` varchar(50) DEFAULT NULL,
  `DateUpdated` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `report`
--

CREATE TABLE `report` (
  `ReportID` int(11) NOT NULL,
  `ReportType` varchar(30) DEFAULT 'Error Report',
  `GenerationDate` datetime NOT NULL DEFAULT current_timestamp(),
  `AssociatedEntity` varchar(50) DEFAULT NULL,
  `Status` enum('Submitted','Not Submitted') NOT NULL DEFAULT 'Submitted',
  `Details` varchar(100) DEFAULT NULL,
  `AdminID` int(11) DEFAULT NULL,
  `DataRange` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `segment`
--

CREATE TABLE `segment` (
  `SegmentID` int(11) NOT NULL,
  `MemberCount` int(11) NOT NULL DEFAULT 0,
  `TagID` int(11) NOT NULL,
  `SegmentName` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `spaceusagelog`
--

CREATE TABLE `spaceusagelog` (
  `LogID` int(11) NOT NULL,
  `AreaID` int(11) NOT NULL,
  `MemberID` int(11) NOT NULL,
  `Date` datetime NOT NULL DEFAULT current_timestamp(),
  `Purpose` varchar(100) DEFAULT NULL,
  `Duration` varchar(10) NOT NULL DEFAULT 'DAY',
  `AlertFlag` tinyint(1) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `survey`
--

CREATE TABLE `survey` (
  `SurveyID` int(11) NOT NULL,
  `SurveyTime` datetime NOT NULL DEFAULT current_timestamp(),
  `FeedbackCategory` varchar(30) DEFAULT NULL,
  `SurveyType` varchar(30) DEFAULT NULL,
  `MemberID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `usedmemberbenefits`
--

CREATE TABLE `usedmemberbenefits` (
  `UsedMemberBenefitsID` int(11) NOT NULL,
  `MemberID` int(11) NOT NULL,
  `MembershipBenefitsID` int(11) NOT NULL,
  `UsageDate` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `UserID` int(11) NOT NULL,
  `FirstName` varchar(50) NOT NULL,
  `LastName` varchar(50) DEFAULT NULL,
  `PhoneNumber` varchar(50) DEFAULT NULL,
  `Email` varchar(100) DEFAULT NULL,
  `HashedPassword` varchar(255) NOT NULL,
  `Status` enum('Active','Not Active') NOT NULL DEFAULT 'Not Active',
  `ProfilePictureAddress` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`UserID`, `FirstName`, `LastName`, `PhoneNumber`, `Email`, `HashedPassword`, `Status`, `ProfilePictureAddress`) VALUES
(1, 'John', 'Doe', '1234567890', 'john.doe@example.com', 'hashed_password_123', 'Active', NULL),
(2, 'Jane', 'Smith', '0987654321', 'jane.smith@example.com', 'hashed_password_456', 'Not Active', 'images/profiles/jane_smith.jpg'),
(3, 'Michael', 'Brown', '5551234567', 'michael.brown@example.com', 'hashed_password_789', 'Active', 'images/profiles/michael_brown.jpg'),
(4, 'Emily', 'Davis', '4449876543', 'emily.davis@example.com', 'hashed_password_012', 'Not Active', 'images/profiles/emily_davis.jpg'),
(5, 'Chris', 'Wilson', '3331112222', 'chris.wilson@example.com', 'hashed_password_345', 'Active', 'images/profiles/chris_wilson.jpg'),
(6, 'Sophia', 'Smith', '555-0106', 'sophia.smith@example.com', 'hashed_pwd_6', 'Active', '/images/profiles/sophia.png'),
(7, 'Liam', 'Johnson', '555-0107', 'liam.johnson@example.com', 'hashed_pwd_7', 'Not Active', '/images/profiles/liam.png'),
(8, 'Olivia', 'Williams', '555-0108', 'olivia.williams@example.com', 'hashed_pwd_8', 'Active', '/images/profiles/olivia.png'),
(9, 'Noah', 'Brown', '555-0109', 'noah.brown@example.com', 'hashed_pwd_9', 'Not Active', '/images/profiles/noah.png'),
(10, 'Ava', 'Davis', '555-0110', 'ava.davis@example.com', 'hashed_pwd_10', 'Active', '/images/profiles/ava.png'),
(201, 'John', 'Doe', '1234567890', 'john.doe@example.com', 'hashedpassword1', 'Active', NULL),
(202, 'Jane', 'Smith', '0987654321', 'jane.smith@example.com', 'hashedpassword2', 'Active', NULL),
(203, 'Alice', 'Brown', '1112223333', 'alice.brown@example.com', 'hashedpassword3', 'Active', NULL),
(204, 'Bob', 'White', '4445556666', 'bob.white@example.com', 'hashedpassword4', 'Active', NULL),
(205, 'Charlie', 'Black', '7778889999', 'charlie.black@example.com', 'hashedpassword5', 'Active', NULL),
(206, 'Diana', 'Green', '1231231234', 'diana.green@example.com', 'hashedpassword6', 'Active', NULL),
(207, 'Eve', 'Blue', '4564564567', 'eve.blue@example.com', 'hashedpassword7', 'Active', NULL),
(208, 'Frank', 'Yellow', '7897897890', 'frank.yellow@example.com', 'hashedpassword8', 'Active', NULL),
(209, 'Grace', 'Pink', '1123581321', 'grace.pink@example.com', 'hashedpassword9', 'Active', NULL),
(210, 'Hank', 'Red', '3141592653', 'hank.red@example.com', 'hashedpassword10', 'Active', NULL),
(211, 'Ivy', 'Violet', '2718281828', 'ivy.violet@example.com', 'hashedpassword11', 'Active', NULL),
(212, 'Jack', 'Orange', '1618033988', 'jack.orange@example.com', 'hashedpassword12', 'Active', NULL),
(213, 'Kate', 'Brown', '1414213562', 'kate.brown@example.com', 'hashedpassword13', 'Active', NULL),
(214, 'Leo', 'Gray', '1732050807', 'leo.gray@example.com', 'hashedpassword14', 'Active', NULL),


-- --------------------------------------------------------

--
-- Table structure for table `userengagement`
--

CREATE TABLE `userengagement` (
  `EngagementID` int(11) NOT NULL,
  `NumberOfEngagements` int(11) NOT NULL DEFAULT 0,
  `UserID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `usertag`
--

CREATE TABLE `usertag` (
  `UserID` int(11) NOT NULL,
  `TagID` int(11) NOT NULL,
  `DateOfInterest` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `visitorlog`
--

CREATE TABLE `visitorlog` (
  `VisitorLogID` int(11) NOT NULL,
  `UserID` int(11) NOT NULL,
  `VisitDate` datetime NOT NULL DEFAULT current_timestamp(),
  `PurposeOfVisit` varchar(100) DEFAULT NULL,
  `DurationOfStay` varchar(10) NOT NULL DEFAULT 'DAY'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `visitorlog`
--

INSERT INTO `visitorlog` (`VisitorLogID`, `UserID`, `VisitDate`, `PurposeOfVisit`, `DurationOfStay`) VALUES
(1, 1, '2024-12-01 10:30:00', 'Meeting with Manager', '2 HOURS'),
(2, 2, '2024-12-02 11:15:00', 'Project Discussion', '3 HOURS'),
(3, 3, '2024-12-03 09:45:00', 'Site Inspection', '1.5 HOURS'),
(4, 4, '2024-12-04 14:20:00', 'Consultation', '2 HOURS'),
(5, 5, '2024-12-05 15:00:00', 'Follow-up Meeting', '1 HOUR'),
(6, 6, '2024-12-06 13:10:00', 'Training Session', '4 HOURS'),
(7, 7, '2024-12-07 08:55:00', 'System Maintenance', '3 HOURS'),
(8, 8, '2024-12-08 12:30:00', 'Client Visit', '2 HOURS'),
(9, 9, '2024-12-09 10:00:00', 'Team Building Activity', '3.5 HOURS'),
(10, 10, '2024-12-10 16:45:00', 'Equipment Delivery', '1 HOUR');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`AdminID`),
  ADD KEY `UserID` (`UserID`);

--
-- Indexes for table `adminrequests`
--
ALTER TABLE `adminrequests`
  ADD PRIMARY KEY (`AdminRequestID`),
  ADD KEY `UserID` (`UserID`);

--
-- Indexes for table `area`
--
ALTER TABLE `area`
  ADD PRIMARY KEY (`AreaID`);

--
-- Indexes for table `areaattendance`
--
ALTER TABLE `areaattendance`
  ADD PRIMARY KEY (`AreaAttendanceID`),
  ADD KEY `AreaID` (`AreaID`);

--
-- Indexes for table `engagementactivity`
--
ALTER TABLE `engagementactivity`
  ADD PRIMARY KEY (`ActivityID`),
  ADD KEY `EngagementID` (`EngagementID`);

--
-- Indexes for table `event`
--
ALTER TABLE `event`
  ADD PRIMARY KEY (`EventID`),
  ADD KEY `TagID` (`TagID`);

--
-- Indexes for table `eventbooking`
--
ALTER TABLE `eventbooking`
  ADD PRIMARY KEY (`BookingID`),
  ADD KEY `EventID` (`EventID`),
  ADD KEY `UserID` (`UserID`);

--
-- Indexes for table `feedback`
--
ALTER TABLE `feedback`
  ADD PRIMARY KEY (`FeedbackID`),
  ADD KEY `BookingID` (`BookingID`),
  ADD KEY `UserID` (`UserID`);

--
-- Indexes for table `interesttag`
--
ALTER TABLE `interesttag`
  ADD PRIMARY KEY (`TagID`);

--
-- Indexes for table `keyvalue`
--
ALTER TABLE `keyvalue`
  ADD PRIMARY KEY (`ValueID`);

--
-- Indexes for table `mailinglistsubscription`
--
ALTER TABLE `mailinglistsubscription`
  ADD PRIMARY KEY (`SubscriptionID`),
  ADD KEY `UserID` (`UserID`);

--
-- Indexes for table `member`
--
ALTER TABLE `member`
  ADD PRIMARY KEY (`MemberID`),
  ADD KEY `MembershipTypeID` (`MembershipTypeID`),
  ADD KEY `UserID` (`UserID`),
  ADD KEY `SegmentID` (`SegmentID`),
  ADD KEY `ValueID` (`ValueID`);

--
-- Indexes for table `membershipbenefits`
--
ALTER TABLE `membershipbenefits`
  ADD PRIMARY KEY (`MembershipBenefitsID`);

--
-- Indexes for table `membershiptype`
--
ALTER TABLE `membershiptype`
  ADD PRIMARY KEY (`MembershipTypeID`);

--
-- Indexes for table `membershiptypebenefits`
--
ALTER TABLE `membershiptypebenefits`
  ADD PRIMARY KEY (`MembershipTypeID`,`MembershipBenefitsID`),
  ADD KEY `MembershipBenefitsID` (`MembershipBenefitsID`);

--
-- Indexes for table `payment`
--
ALTER TABLE `payment`
  ADD PRIMARY KEY (`PaymentID`),
  ADD KEY `UserID` (`UserID`),
  ADD KEY `BookingID` (`BookingID`);

--
-- Indexes for table `potentialmember`
--
ALTER TABLE `potentialmember`
  ADD PRIMARY KEY (`PotentialMemberID`),
  ADD KEY `UserID` (`UserID`),
  ADD KEY `SegmentID` (`SegmentID`);

--
-- Indexes for table `preferences`
--
ALTER TABLE `preferences`
  ADD PRIMARY KEY (`PreferenceID`),
  ADD KEY `MemberID` (`MemberID`);

--
-- Indexes for table `report`
--
ALTER TABLE `report`
  ADD PRIMARY KEY (`ReportID`),
  ADD KEY `AdminID` (`AdminID`);

--
-- Indexes for table `segment`
--
ALTER TABLE `segment`
  ADD PRIMARY KEY (`SegmentID`),
  ADD KEY `TagID` (`TagID`);

--
-- Indexes for table `spaceusagelog`
--
ALTER TABLE `spaceusagelog`
  ADD PRIMARY KEY (`LogID`),
  ADD KEY `AreaID` (`AreaID`),
  ADD KEY `MemberID` (`MemberID`);

--
-- Indexes for table `survey`
--
ALTER TABLE `survey`
  ADD PRIMARY KEY (`SurveyID`),
  ADD KEY `MemberID` (`MemberID`);

--
-- Indexes for table `usedmemberbenefits`
--
ALTER TABLE `usedmemberbenefits`
  ADD PRIMARY KEY (`UsedMemberBenefitsID`),
  ADD KEY `MemberID` (`MemberID`),
  ADD KEY `MembershipBenefitsID` (`MembershipBenefitsID`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`UserID`);

--
-- Indexes for table `userengagement`
--
ALTER TABLE `userengagement`
  ADD PRIMARY KEY (`EngagementID`),
  ADD KEY `UserID` (`UserID`);

--
-- Indexes for table `usertag`
--
ALTER TABLE `usertag`
  ADD PRIMARY KEY (`UserID`,`TagID`),
  ADD KEY `TagID` (`TagID`);

--
-- Indexes for table `visitorlog`
--
ALTER TABLE `visitorlog`
  ADD PRIMARY KEY (`VisitorLogID`),
  ADD KEY `UserID` (`UserID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `admin`
--
ALTER TABLE `admin`
  MODIFY `AdminID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `adminrequests`
--
ALTER TABLE `adminrequests`
  MODIFY `AdminRequestID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `area`
--
ALTER TABLE `area`
  MODIFY `AreaID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `areaattendance`
--
ALTER TABLE `areaattendance`
  MODIFY `AreaAttendanceID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `engagementactivity`
--
ALTER TABLE `engagementactivity`
  MODIFY `ActivityID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `event`
--
ALTER TABLE `event`
  MODIFY `EventID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `eventbooking`
--
ALTER TABLE `eventbooking`
  MODIFY `BookingID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=112;

--
-- AUTO_INCREMENT for table `feedback`
--
ALTER TABLE `feedback`
  MODIFY `FeedbackID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `interesttag`
--
ALTER TABLE `interesttag`
  MODIFY `TagID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=111;

--
-- AUTO_INCREMENT for table `keyvalue`
--
ALTER TABLE `keyvalue`
  MODIFY `ValueID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `mailinglistsubscription`
--
ALTER TABLE `mailinglistsubscription`
  MODIFY `SubscriptionID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `member`
--
ALTER TABLE `member`
  MODIFY `MemberID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `membershipbenefits`
--
ALTER TABLE `membershipbenefits`
  MODIFY `MembershipBenefitsID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `membershiptype`
--
ALTER TABLE `membershiptype`
  MODIFY `MembershipTypeID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `payment`
--
ALTER TABLE `payment`
  MODIFY `PaymentID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `potentialmember`
--
ALTER TABLE `potentialmember`
  MODIFY `PotentialMemberID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `preferences`
--
ALTER TABLE `preferences`
  MODIFY `PreferenceID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `report`
--
ALTER TABLE `report`
  MODIFY `ReportID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `segment`
--
ALTER TABLE `segment`
  MODIFY `SegmentID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `spaceusagelog`
--
ALTER TABLE `spaceusagelog`
  MODIFY `LogID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `survey`
--
ALTER TABLE `survey`
  MODIFY `SurveyID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `usedmemberbenefits`
--
ALTER TABLE `usedmemberbenefits`
  MODIFY `UsedMemberBenefitsID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `UserID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=217;

--
-- AUTO_INCREMENT for table `userengagement`
--
ALTER TABLE `userengagement`
  MODIFY `EngagementID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `visitorlog`
--
ALTER TABLE `visitorlog`
  MODIFY `VisitorLogID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `admin`
--
ALTER TABLE `admin`
  ADD CONSTRAINT `admin_ibfk_1` FOREIGN KEY (`UserID`) REFERENCES `user` (`UserID`);

--
-- Constraints for table `adminrequests`
--
ALTER TABLE `adminrequests`
  ADD CONSTRAINT `adminrequests_ibfk_1` FOREIGN KEY (`UserID`) REFERENCES `user` (`UserID`);

--
-- Constraints for table `areaattendance`
--
ALTER TABLE `areaattendance`
  ADD CONSTRAINT `areaattendance_ibfk_1` FOREIGN KEY (`AreaID`) REFERENCES `area` (`AreaID`);

--
-- Constraints for table `engagementactivity`
--
ALTER TABLE `engagementactivity`
  ADD CONSTRAINT `engagementactivity_ibfk_1` FOREIGN KEY (`EngagementID`) REFERENCES `userengagement` (`EngagementID`);

--
-- Constraints for table `event`
--
ALTER TABLE `event`
  ADD CONSTRAINT `event_ibfk_1` FOREIGN KEY (`TagID`) REFERENCES `interesttag` (`TagID`);

--
-- Constraints for table `eventbooking`
--
ALTER TABLE `eventbooking`
  ADD CONSTRAINT `eventbooking_ibfk_1` FOREIGN KEY (`EventID`) REFERENCES `event` (`EventID`),
  ADD CONSTRAINT `eventbooking_ibfk_2` FOREIGN KEY (`UserID`) REFERENCES `user` (`UserID`);

--
-- Constraints for table `feedback`
--
ALTER TABLE `feedback`
  ADD CONSTRAINT `feedback_ibfk_1` FOREIGN KEY (`BookingID`) REFERENCES `eventbooking` (`BookingID`),
  ADD CONSTRAINT `feedback_ibfk_2` FOREIGN KEY (`UserID`) REFERENCES `user` (`UserID`);

--
-- Constraints for table `mailinglistsubscription`
--
ALTER TABLE `mailinglistsubscription`
  ADD CONSTRAINT `mailinglistsubscription_ibfk_1` FOREIGN KEY (`UserID`) REFERENCES `user` (`UserID`);

--
-- Constraints for table `member`
--
ALTER TABLE `member`
  ADD CONSTRAINT `member_ibfk_1` FOREIGN KEY (`MembershipTypeID`) REFERENCES `membershiptype` (`MembershipTypeID`),
  ADD CONSTRAINT `member_ibfk_2` FOREIGN KEY (`UserID`) REFERENCES `user` (`UserID`),
  ADD CONSTRAINT `member_ibfk_3` FOREIGN KEY (`SegmentID`) REFERENCES `segment` (`SegmentID`),
  ADD CONSTRAINT `member_ibfk_4` FOREIGN KEY (`ValueID`) REFERENCES `keyvalue` (`ValueID`);

--
-- Constraints for table `membershiptypebenefits`
--
ALTER TABLE `membershiptypebenefits`
  ADD CONSTRAINT `membershiptypebenefits_ibfk_1` FOREIGN KEY (`MembershipTypeID`) REFERENCES `membershiptype` (`MembershipTypeID`),
  ADD CONSTRAINT `membershiptypebenefits_ibfk_2` FOREIGN KEY (`MembershipBenefitsID`) REFERENCES `membershipbenefits` (`MembershipBenefitsID`);

--
-- Constraints for table `payment`
--
ALTER TABLE `payment`
  ADD CONSTRAINT `payment_ibfk_1` FOREIGN KEY (`UserID`) REFERENCES `user` (`UserID`),
  ADD CONSTRAINT `payment_ibfk_2` FOREIGN KEY (`BookingID`) REFERENCES `eventbooking` (`BookingID`);

--
-- Constraints for table `potentialmember`
--
ALTER TABLE `potentialmember`
  ADD CONSTRAINT `potentialmember_ibfk_1` FOREIGN KEY (`UserID`) REFERENCES `user` (`UserID`),
  ADD CONSTRAINT `potentialmember_ibfk_2` FOREIGN KEY (`SegmentID`) REFERENCES `segment` (`SegmentID`);

--
-- Constraints for table `preferences`
--
ALTER TABLE `preferences`
  ADD CONSTRAINT `preferences_ibfk_1` FOREIGN KEY (`MemberID`) REFERENCES `member` (`MemberID`);

--
-- Constraints for table `report`
--
ALTER TABLE `report`
  ADD CONSTRAINT `report_ibfk_1` FOREIGN KEY (`AdminID`) REFERENCES `admin` (`AdminID`);

--
-- Constraints for table `segment`
--
ALTER TABLE `segment`
  ADD CONSTRAINT `segment_ibfk_1` FOREIGN KEY (`TagID`) REFERENCES `interesttag` (`TagID`);

--
-- Constraints for table `spaceusagelog`
--
ALTER TABLE `spaceusagelog`
  ADD CONSTRAINT `spaceusagelog_ibfk_1` FOREIGN KEY (`AreaID`) REFERENCES `area` (`AreaID`),
  ADD CONSTRAINT `spaceusagelog_ibfk_2` FOREIGN KEY (`MemberID`) REFERENCES `member` (`MemberID`);

--
-- Constraints for table `survey`
--
ALTER TABLE `survey`
  ADD CONSTRAINT `survey_ibfk_1` FOREIGN KEY (`MemberID`) REFERENCES `member` (`MemberID`);

--
-- Constraints for table `usedmemberbenefits`
--
ALTER TABLE `usedmemberbenefits`
  ADD CONSTRAINT `usedmemberbenefits_ibfk_1` FOREIGN KEY (`MemberID`) REFERENCES `member` (`MemberID`),
  ADD CONSTRAINT `usedmemberbenefits_ibfk_2` FOREIGN KEY (`MembershipBenefitsID`) REFERENCES `membershipbenefits` (`MembershipBenefitsID`);

--
-- Constraints for table `userengagement`
--
ALTER TABLE `userengagement`
  ADD CONSTRAINT `userengagement_ibfk_1` FOREIGN KEY (`UserID`) REFERENCES `user` (`UserID`);

--
-- Constraints for table `usertag`
--
ALTER TABLE `usertag`
  ADD CONSTRAINT `usertag_ibfk_1` FOREIGN KEY (`UserID`) REFERENCES `user` (`UserID`),
  ADD CONSTRAINT `usertag_ibfk_2` FOREIGN KEY (`TagID`) REFERENCES `interesttag` (`TagID`);

--
-- Constraints for table `visitorlog`
--
ALTER TABLE `visitorlog`
  ADD CONSTRAINT `visitorlog_ibfk_1` FOREIGN KEY (`UserID`) REFERENCES `user` (`UserID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
