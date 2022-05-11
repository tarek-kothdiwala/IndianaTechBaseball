# IndianaTechBaseball
This repository includes information on my Azure ASP.NET web app with SQL Database showing Indiana Tech Baseball 2022 statistics. 

## Project Overview

- This project for Cloud Computing is using a two-tier model. It is compromised of a front-end ASP.NET web app with a back-end SQL Database portion. It displays statistics for the Indiana Tech Warriors 2022 baseball season, of which I am a part of and passionate about. 
- The "Hitting" statistics page shows all of the hitters' statistics in the 2022 season by using an ASP.NET web app. The "Pitching" statistics page shows all of the pitchers' statisitcs in the 2022 season through a back-end SQL Database that is linked to the front-end ASP.NET web app. 
- For the SQL Database, I planned on manually inputting pitchers' data into the SQL database of each pitcher on the team, while still being able to add new pitchers, edit, and delete rows using the front-end web application as updated statistics become available for pitchers (as I am a pitcher as well). 

## Diagram
 - I used Microsoft Visio for a visual representation of this project to show how everything is connected to each other in my resource group. 
 - It includes dependencies, for example, the SQL Database is dependent on the SQL Server, and the Web Application is hosted by the Web App Plan and how they are connected between each other through the connection string. 
![Diagram (Visio)](https://user-images.githubusercontent.com/103961256/167728461-bf570a23-5af2-4df6-9b69-ed65fa00e468.PNG)

## Services
#### Azure App Service
 - Why: I Used an app service for its ease of use in hosting my website that is publicly accessible. It is able to manage multiple different frameworks and different programming languages (used mainly HTML and C# for mine). 
 - Purpose: The purpose for my app service was to be able to allow anyone to access the Indiana Tech 2022 Baseball statistics easily in a very user friendly way, and the app service, with its built-in frameworks, allowed for ease of publishing to the web what I intended. 
#### Azure App Service Plan
 - Why: The app service plan is created for the web app to run since it defines computer resources for it.
 - Purpose: The purpose of the app service plan is to define the operating system, region, pricing tier, etc. Basically, the app service plan determines my features of my app service and how much to pay for those features I have chosen. 
#### Azure SQL Database
 - Why: The SQL database is a relational database service to hold tables, data, and ultimetely pull queries. 
 - Purpose: The purpose of the SQL database is to be able to pull the query defined to the web app for users to see and then be able to add data, edit, and delete the data as they, so please. Data can be added from both front-end (by the public user) and back-end (by an admin - like me). Main purpose of accessing, updating, and maintaining data. 
#### Azure SQL Server
 - Why: The SQL server is the SQL databases' management system to support the many analytics, transaction, and business intelligence operations behind the scenes. 
 - Purpose: The SQL server's purpose is to be the database engine to the SQL database and control data storage and help execute my queries for the database. 

## Azure Well-Architected Framework
#### Reliability
- My services are quite reliable since I have made many Geo-redundant services, which provide high availability and durability for hosting data and the application implemented. This ensures that it will be reliable even in the event of an outage, where data is synchronously replicated in the primary region and also asynchronously replicated to a secondary region that is far away. 
#### Security
- My services are quite secure since my SQL Database, Server, and connection string all have credentials to gain access to them. The web page is also quite secure since it is running on HTTPS (Hypertext Transfer Protocol Secure). This allows for a very protected and confidential user experience when accessing the web app but also against those who intend to do malicious things. 
#### Cost Optimization
- I have managed my costs very effectively for the value being delivered. For my SQL Database/Server, I have an estimated monthly cost of $4.99/month using the Basic service tier due to the less demanding workload.  For my app service/app service plan, I am currently using the Free pricing tier, which allows for up to 1 GB of memory and 60 mins/day compute at no charge, which is great for the minimal workload on the web app service. 
 - ![CC 8](https://user-images.githubusercontent.com/103961256/167781799-27a58cfa-30f3-4914-957c-c70928dc580a.PNG)

#### Operational Excellence
- In terms of the operational excellence side of things, the services and processes I have implemented creates an environment where the applications running remain in production. They are very reliable and predictable since it is using a simple two-tier model with not many moving parts. Nothing really slows down any of the processes with the resources I have deployed for this project. 
#### Performance Efficiency
 - The performance efficiency is great for the computing power that needs to be done between the SQL side of things as well as the front-end web app service side. It takes very little computing power to run what I am running - mainly filling tables of data from different sources (web app and SQL Database). The entire project is quite efficient in its performance and has the ability to be edited or even torn down and republished perfectly at a moment's notice. 
## Future Revisions
 - For future revisions, I would add functionality to the add pitcher, edit, and delete buttons and brush up on my HTML codding experience by being able to have the public user-editable and writable data from the SQL database within the web app. If I had more time, I would have experimented with this and did additional research on how to make this work in order to update the back-end SQL database using the front-end web app as originally envisioned. 
 - I would also like to make it more aesthetically appealing by adding logos, sponsors, ads, etc., into the web page and not just have it entirely a functional web page but more appealing and enjoyable to view for the user. 
 - Additionally, to make the website more complete in nature, I would add a schedule that would also link to a SQL database with the entire season schedule with the ability to edit scores and results of games. 
