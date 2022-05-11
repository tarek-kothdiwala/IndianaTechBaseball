# IndianaTechBaseball
This repository includes information on my Azure ASP.NET web app with SQL Database showing Indiana Tech Baseball 2022 statistics. 

## Project Overview

- This project for Cloud Computing is using a two-tier model. It is compromised of a front-end ASP.NET web app with a back-end SQL Database portion. It displays statistics for the Indiana Tech Warriors 2022 baseball season, of which I am apart of and passionate about. 
- The "Hitting" statistics page shows all of the hitters statistics in the 2022 season through using an ASP.NET web app. The "Pitching" statistics page shows all of the pitchers statisitcs in the 2022 season through a back-end SQL Database that is linked to the front-end ASP.NET web app. 
- For the SQL Database, I planned on manually inputting pitchers data into the SQL database of each pitcher on the team, while still being able to add new pitchers, edit, and delete rows using the front-end web application as up dated statistics become available for pitchers (as I am a pitcher as well). 

## Diagram
 - I used Micrsoft Visio for a visual representation of this project to show how everything is connected to each other in my resource group. 
 - It includes dependancies, for example, the SQL Database is dependant on the SQL Server and the Web Application is hosted by the Web App Plan and how they are connected between each other through the connection string. 
![Diagram (Visio)](https://user-images.githubusercontent.com/103961256/167728461-bf570a23-5af2-4df6-9b69-ed65fa00e468.PNG)

## Services
#### Azure App Service
 - Why: I Used an app service for its ease of use in hosting my website that is publicly accessible. It is able to manage multiple different frameworks and different programming languages (used mainly HTML and C# for mine). 
 - Purpose: The purpose for my app service was to be able to allow anyone to access the Indiana Tech 2022 Baseball statistics easily in a very user frendly way and the app service with its built in frameworks allowed for ease of publishing to the web what I intended. 
#### Azure App Service Plan
 - Why: The app service plan is created for the web app to run since it defines computer resources for it.
 - Purpose: The purpose of the app service plan is to define the operating system, region, pricing tier, etc. Basically the app service plan determines my features of my app service and how much to pay for those features I have chosen. 
#### Azure SQL Database
 - Why: The SQL database is a relational database service to hold tables, data and ultimetely pull queries. 
 - Purpose: The purpose of the SQL database is to be able to pull the query defined to the web app for users to see and then be able to add data, edit, and delete the data as they so please. Data can be added from both front-end (by the public user) and back-end (by an admin - like me). Main purpose of accessing, updating, and maintaining data. 
#### Azure SQL Server
 - Why: The SQL server is the SQL databases' management system to support the many analytics, transaction, and business intelligence operations behind the scenes. 
 - Purpose: The SQL server's purpose is be the database engine to the SQL database and control data storage and help execute my queries for the database. 

## Azure Well-Architected Framework
#### Reliability

#### Security

#### Cost Optimization

#### Operational Excellence

#### Performance Efficiency

## Futute Revisions
