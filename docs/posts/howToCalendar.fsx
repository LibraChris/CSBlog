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
In the beginning I tried to look at online hosted services that, preferably one that allows for the following traits: 

- Multiple calendars, preferably one for every server
- Personalized user accounts with individual passwords
- Customizable calendars with custom mandatory fields
    - f.E.: predicted core usage for the task
- And most importantly: <b>Free to use</b>

One service that fulfilled the qualifications was [teamup](https://www.teamup.com/).
![teamup Server CSB1](../img/CSB Server Teamup1.png)
![teamup Server CSB2](../img/CSB Server Teamup2.png)

But while it may provide the service I originally sought out, it did come with some major limitations in its free version:

- Number of calendars set to 8
- Only one customizable field for events
- 8 user max

## Why self-hosting a calendar may be a good idea
After a quick talk with Timo I came to the conclusion that the limitations of [teamup](https://www.teamup.com/), especially its 
dependency on a subscription model for the best features would hinder a potential future expansion of the server count/structure. 
One simple solution to this problem would be a self-hosted calendar service. 
Some benefits would be:

- The safety of knowing that our calendar data is safe on one of our own servers
- Autonomy from any kind of service provider
- A wide selection of potential services

## CalDAV
a
## Our current system
a
## Step by step guide
s
## Github Actions
a
## Self-hosted alternatives
a
### Server
- [Radicale](https://radicale.org/3.0.html)
- [Baïkal](https://sabre.io/baikal/)

### Interface
- [InfCloud](https://www.inf-it.com/open-source/clients/infcloud/)

## Further reading

- [Reddit source for self-hosted services](https://www.reddit.com/r/selfhosted/)
- [Github repo for self-hosted servives](https://github.com/awesome-selfhosted/awesome-selfhosted)

*)