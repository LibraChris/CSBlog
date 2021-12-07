(**

---
title: How to Calendar
category: Tools
categoryindex: 5
index: 0
---

# An introduction to our self-hosted calendar on HyperV for server booking

## Content
- [The joys of a working booking system](#The-joys-of-a-working-booking-system)
- [The not self-hosted beginnings](#The-not-self-hosted-beginnings)
- [Why self-hosting a calendar may be a good idea](#Why-self-hosting-a-calendar-may-be-a-good-idea)
- [CalDAV](#CalDAV)
- [Our current system](#Our-current-system)
- [Step by step guide](#Step-by-step-guide)
- [Github Actions](#Github-Actions)
- [Self-hosted alternatives](#Self-hosted-alternatives)
- [Further reading](#Further-reading)

## The joys of a working booking system
While working with large datasets, the average desktop pc can easily meet its limitations. 
For that purpose, working on a server allows for a streamlined data evaluation that does not need to be constantly supervised. 
With the growing number of people that are dependent on the servers for their analysis it has become tedious to ask around if anybody needs one of the servers urgently for an assignment. 
A booking system not only allows to bypass this problem, but allows for an easy overview of the planned server activity.    
## The not self-hosted beginnings
The first step was looking at online hosted services, preferably one that allows for the following traits: 

- Multiple calendars, preferably one for every server
- Personalized user accounts with individual passwords
- Customizable calendars with custom mandatory fields
    - f.E.: predicted core usage for the task
- And most importantly: <b>Free to use</b>

One service that fulfilled the qualifications was [teamup](https://www.teamup.com/).
![teamup Server CSB1](../img/CSB Server Teamup1.png)
![teamup Server CSB2](../img/CSB Server Teamup2.png)

But while it fulfilled the desired properties, it did come with some major limitations in its free version:

- Number of calendars set to 8
- Only one customizable field for events
- 8 user max

## Why self-hosting a calendar may be a good idea
After a short conversation within the group it was concluded that the limits of [teamup](https://www.teamup.com/), especially its 
dependency on a subscription model for the best features would hinder a potential future expansion of the server count/structure. 
One simple solution to this problem would be a self-hosted calendar service. 
Some benefits would be:

- The safety of knowing that our calendar data is safe on one of our own servers
- Autonomy from any kind of service provider
- A wide selection of potential services

## CalDAV
The first step in kickstarting our own calendar-app is understanding the structure of an online calendar. Most online calendar services use the same protocol for its calendar data, CalDAV.
<abbr title="Calendar Distributed Authoring and Versioning">CalDAV</abbr> is an internet standard for accessing scheduling information on a remote server.
It is based on [WebDav](www.webdav.org) and is the necessary format of our backend.

## Self-hosted alternatives
When looking for self-hosted calendar services, at least one of the following services is definitely recommended: 

### CalDav Server
- [Radicale](https://radicale.org/3.0.html)
- [Baïkal](https://sabre.io/baikal/) 

### Interface
- [InfCloud](https://www.inf-it.com/open-source/clients/infcloud/)

## Our current system
After a lot of research into different CalDAV servers and clients, already pre-packaged docker-containers for calendar applications came into consideration.
In the end, [docker-baikal-infcloud](https://github.com/bjuretko/docker-baikal-infcloud) was chosen. It uses two distinct services for the calendar application:
### Backend: Baïkal
[Baïkal](https://sabre.io/baikal/) is a CalDAV server that allows for an easy management of its data via an extensive web interface. 
The calendar data can be stored as a MySQL or a SQLite database, depending on what the user preference.
### Frontend: InfCloud
[InfCloud](https://www.inf-it.com/open-source/clients/infcloud/) is an open source CalDAV web client implementation, that is one of the best known web clients for self-hosted calendar services.
It also allows for cross-domain setup with the CalDAV server and different authentication setups, depending on user preference. 

## Step by step guide
s
## Github Actions
Github Actions allows for the automation of your git workflow, allowing for an easier development across multiple platforms and operating systems. 
In case of an always working web service, such as the calendar app, it makes sense to put certain tests in place for the service itself and its database operations.


This part is still in development since I know next to noting about it and most likely will ask for guidance once again. 

## Further reading

- [Reddit source for self-hosted services](https://www.reddit.com/r/selfhosted/)
- [Github repo for self-hosted servives](https://github.com/awesome-selfhosted/awesome-selfhosted)
- [Radicale](https://radicale.org/3.0.html)
- [Baïkal](https://sabre.io/baikal/)
- [InfCloud](https://www.inf-it.com/open-source/clients/infcloud/)

*)