# GPS Based Train Tracking System

Project Requirements Specification Document


Group 4 : Jithin Pradeep(www.jithinjp.in), Antony Jino, Midhula Vijayan, Najeera PM
Version: 0.9        	                                                               
Date: (11/02/2011)




## Table of Contents
{:.no_toc}
0. this unordered seed list will be replaced by toc as unordered list
{:toc}

### 1 Introduction
#### 1.1 Purpose 

The primary objective of this document is to illustrate the requirements of the project ‘Train tracking system using GPS’.  The document gives the detailed description of both the functional and nonfunctional requirements proposed. The data is developed after some consultations with the client and considering the complete requirement of the project. The final product of the team will be meeting the requirements of this document. 

#### 1.2 Scope

Nowadays Railways play a significant role in transporting people and goods from one place to another. An innumerable number of trains are running across the nation. It will be a great boon if we can get the exact position of a train at any instant. This can be best realized with the recent technology era. The technology is with satellite communication techs like GPS, GSM, and GPRS.
The proposed software product is for tracking train using GPS. It provides passengers traveling on the train specially for passengers in AC coaches, the details of various locations and time to reach each station. It can also provide passengers with the details about the delays caused at each location if any. The software can also provide passengers waiting at the station the details about the trains that will be reaching soon at their respective stations. 
The software can also help in getting the train details through message for the registered passengers on request. Moreover, this software can help railway authorities to instantly map the train position on to Google map and also helps in organizing journey details at the end of each. The current system does not provide any provision for mapping the train instantly. Also, there are no active methods for letting the passengers in knowing about the time to reach the destination and how much delay has happened in the case of a delay. Also currently there is no provision to track a train externally through messages.

#### 1.3 Definitions, Acronyms, and Abbreviations:  

GPS                        	Global positioning system
GSM			Global System Module
GUI                        	Graphical User Interface
SMS                                   Short Message Service
RMB                                 Recommended minimum navigation information

(NMEA standard)   
NMEA			National Marine Electronics Association
The National Marine Electronics Association (NMEA)    has developed a specification that defines the interface between various pieces of marine electronic equipment. The standard permits marine electronics to send information to computers and to other marine equipment.

Product requires mainly two types of system

- **Central system**, one which is used to coordinate entire process centrally and maintain the central database system.
- **Train system**, the second type of system is installed inside the train along with the GPS modules to perform the real-time calculation for that train, update detail to a central database or central system and make significant announcement inside the train.


Station, it can be the source, destination or the intermediate station.
An intermediate station, are either arbitrary station marked or the position where the train has paused the journey due delay or some other factor.  Train number, a unique number assigned to train in railway to identify them.

#### 1.4 References

The applicable IEEE standards are published in “IEEE standards  

- Software Engineering, A Practitioner’s approach, 6th edition.  By Roger S Pressman.  McGraw hill international.
- Fundamentals of Software engineering, Third Edition. By Rajib Mall. PHI Eastern Economy Edition.
- NMEA format: To provide data transfer between the GPS transmitter and the receiver.

#### 1.5 Overview	

We have identified the needs of the passengers during a journey and of the railway authorities to organize the journey details. The objective of this document is to describe the system’s high-level requirements including functional requirements, non-functional requirements and the various constraints. The detailed structure of this document is organized as follows:
##### 1.5.1 Section 2

This section of the SRS will provide the general factors that affect the product and its requirements. It provides the background for those requirements. The items such as product perspective, product functions, user characteristics, constraints, assumptions and dependencies and requirement subsets are described in this section.

##### 1.5.2 Section 3

 This section of SRS contains all the software requirements mentioned in section 2 in detail sufficient enough to enable designers to design the system to satisfy the requirements and the testers to test if the system satisfies those requirements.



### 2. Overall description

#### 2.1 Product perspective:


This is proposed to be a service that can be provided by the railway to the passengers in order to make the journey or preparation for the journey more comfortable. Many flaws in a present system like we cannot predict arrival time of train accurately, for the passenger at the strange place he cannot predict this arrival of his destination railway station, and also cannot pinpoint the current location of the train. The Software Requirements Specifications intends to identify a solution to all.

#### 2.2 Product Functions:	


The train tracking system using GPS is supposed to do the following  functions:

- The system allows the passengers to know about the name and time to reach stations with mapping a current position of trains to reach a station on Google map and to display other required details.

- The system makes announcements at 
  - At the starting station
  - At intermediate stations
  - During unexpected delays during the journey.
- To help the passengers inside the train during the course of the journey. The system allows the authority to map the train instantly on the Google map and generate the journey detail at the end of the journey. 
- Tracking of the train is also possible through SMS if requested at the time of reservation.

#### 2.3 System Environment:	

Diagram below illustrate system environment        

![System overview](/poster.jpg)

#### 2.4 User classes and characteristics:


There are 4 kinds of users for the proposed system


##### 2.4.1 Administrators/Railway authority

- They register the users and provide  the flash messages and also they can avail the current position of the train.  

- They must provide rules for the train tracks.
- They must maintain the database and update the same making necessary changes at times.
- They must take care of the security issues involved in the tracking.
- Any failures in the system have to be detected and repaired.

##### 2.4.2 Passengers at the station

They must get announcements about

-  A number of passengers currently traveling on the train next to arrive.

-  Options regarding other trains that are going to arrive next in  the station with the time taken to reach that station plus the detail of expected arrival at a different station for a particular train according to the current situation.

##### 2.4.3 Passengers Inside the train

They must get announcements about

- Name and time to reach the next station.
- The time required for the completion of the journey or to reach the destination station.

##### 2.4.4 SMS tracking on request

- The request can be registered at the time of reservation

- All passengers tracking through SMS will get the details of train till the station where the reservation was made as flash messages on their mobile number once the train starts from the source station of the journey or on the day of the journey.  

#### 2.5 Assumptions and Dependencies

- Keeps the software as user-friendly as possible

- The administrative users must have sufficient knowledge of the computer but not in the case of other classes of the user mentioned above in [System Environment](#system-environment)
- The users know the English language, as the user interface will be provided in English
- Full working of the system depends on the availability of GPS signals and GSM connection along with an internet connection 



### 3. Specific Requirements

#### 3.1 External Interface

##### 3.1.1 User Interfaces

- The application will be accessed through GUI and output will be made available to the user using voice announcement and GUI.
- Interfaces used by railway authorities will be based entirely on GUI and for the passengers inside train voice announcement and GUI interface will be used to make output avail to them.
- A passenger at the station will be using the GUI interface to see their trains on the map and avail necessary detail.
  - Users using the SMS facilities will be provided with output using flash messages.

##### 3.1.2 Hardware Interfaces

There are two type of system in use Central system and Train system							 
System requirements for both are as follow:

- Operating system:  Windows Vista or later 
- Processor:  Pentium Dual-Core
- RAM: 1GB
- Hard drive: 40GB or above
- Speakers
- ​GPS Module with GSM connection facilities and NMEA standard RMB                                               

##### 3.1.3 Software Interfaces

A software net logger is required to store the GPS data into a log file
Google map is integrated with the product for the purpose of mapping trains. 

##### 3.1.4 Communications Interfaces

  A GSM module is needed for the transmission of the GPS data from the GPS receiver to the system.FTP is used for various activities involving data transfer between systems.

#### 3.2 Functional Requirements

##### 3.2.1 Inside the train calculation

###### 3.2.1.1Voice Announcement Detail

**Input**: 	         When the train reaches the station, then the station type serve as input
**Output**:        Announcement regarding the wait time at the station and delay if any and expected time to reach the next station and destination station inside the train.
**Processing**: According to station type identified announcement are made by calculating time delay of the journey, time to reach next station from using the database in train system which is updated using GPS information.

###### 3.2.1.2 GUI for passengers

**Input**: 	        Updates regularly no input required to be entered implicitly 
**Output**:       Details of the train with an approx. time of reach at all the next station to arrive and other detail like next station name, delay time. 
**Processing**: required information are fetched from train system database.	

###### 3.2.1.3 Journey detail generation

**Input**: 	         When the train reaches the destination 
**Output**: A log file containing detail of the whole journey
**Processing**: Log file are updated all through the journey for all the GPS data acquired.

##### 3.2.2 At station 

###### 3.2.2.1 Detail of trains plus Mapping

**Input**: No input is needed to be entered implicitly regularly updation of GPS data is taken as input
**Output**:	Expected number of passengers currently traveling in the trains next to arrive. The time is taken to reach that station and mapping those trains to Google map  
More generally mapping of a train along with required train detail will be displayed as an output to this function 

###### 3.2.3 SMS Tracking

###### 3.2.3.1 Registration 

**Input**: Mobile number.
**Output**:	Mobile number along with current station of reservation in entered in the database
Processing: Train number along with a mobile number of requested users is stored in the database.

###### 3.2.3.2 SMS service

**Input**: Once train start from source station or from the day of the journey which comes last
**Output**: Flash messages to all user in the database for a particular train 
**Processing**: Mobile numbers are taken from the database with corresponding train number and detail regarding the train is messaged till the reservation station reaches.



#### 3.3 Nonfunctional Requirements

##### 3.3.1 Performance Requirements

 The database shall be able to accommodate a minimum of 10,000 records. The software shall support multiple users at a time. Mapping updating of trains status must be done in a time interval of 3 to 5 min.
Delay detail must be made available as soon as occurred  

##### 3.3.2 Design Constraints

The product is developed using Visual c and VB script. The backend database for this MySQL server. The system requires a database in order to store real-time data. The database should have backup capabilities. The development of the system will be constrained by the availability of required software.

##### 3.3.3 Software Quality Attribute

The quality of the system is maintained in such a way so that it can be very user-friendly to all the users.  Some others quality considerations such as adaptability, availability, correctness, flexibility, interoperability, maintainability, portability, reliability, reusability, robustness, testability, and usability will also be very seriously taken into consideration.

