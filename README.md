# EventSchedule

Test hexagonal architecture

This project is based on

 * https://herbertograca.com/2017/11/16/explicit-architecture-01-ddd-hexagonal-onion-clean-cqrs-how-i-put-it-all-together/
 * https://www.youtube.com/watch?v=i9Il79a2uBU
 * https://www.eduardopires.net.br/2014/10/tutorial-asp-net-mvc-5-ddd-ef-automapper-ioc-dicas-e-truques/

Just me trying to understand better this architecture concept.

# Database Creation (Mysql)

CREATE DATABASE `event_schedule` /*!40100 DEFAULT CHARACTER SET utf8 */;</br>
CREATE TABLE `events` (</br>
  `EventId` varchar(10) NOT NULL,</br>
  `EventStart` datetime NOT NULL,</br>
  `EventEnd` datetime NOT NULL,</br>
  `Description` varchar(500) NOT NULL,</br>
  `CreatedAt` datetime NOT NULL,</br>
  PRIMARY KEY (`EventId`)</br>
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
