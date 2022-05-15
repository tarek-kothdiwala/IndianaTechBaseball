# IndianaTechBaseball
This repository includes information on my Azure ASP.NET web app with SQL Database showing Indiana Tech Baseball 2022 statistics. Please visit: https://itbaseball.azurewebsites.net/. Visit the master branch of this repository for the Virtual Studio Code and Automation. 

## Project Overview

- This project for Cloud Computing is using a two-tier model. It is compromised of a front-end ASP.NET web app with a back-end SQL Database portion. It displays statistics for the Indiana Tech Warriors 2022 baseball season, of which I am a part of and passionate about. 
- The "Hitting" statistics page shows all of the hitters' statistics in the 2022 season by using an ASP.NET web app. The "Pitching" statistics page shows all of the pitchers' statistics in the 2022 season through a back-end SQL Database that is linked to the front-end ASP.NET web app. 
- For the SQL Database, I planned on manually inputting pitchers' data into the SQL database of each pitcher on the team, while still being able to add new pitchers, edit, and delete rows using the front-end web application as updated statistics become available for pitchers (as I am a pitcher as well). 

<img align="center"> 
 ![ITBaseball - QR](https://user-images.githubusercontent.com/103961256/168485666-75f266a0-89ef-45fe-a375-9b77216cbf80.PNG)
 </img>
- QR Code to website above | website screenshots below 
![ITBaseball - Hitting](https://user-images.githubusercontent.com/103961256/168485467-a294e482-b6e4-48c1-b7ee-30e082000411.PNG)
![ITBaseball - Pitching](https://user-images.githubusercontent.com/103961256/168485491-bbddc43d-6bda-4697-95c1-8531fbd5844f.PNG)

## Diagram
 - I used Microsoft Visio for a visual representation of this project to show how everything is connected to each other in my resource group. 
 - It includes dependencies, for example, the SQL Database is dependent on the SQL Server, and the Web Application is hosted by the Web App Plan and how they are connected between each other through the connection string. 
![Diagram (Visio)](https://user-images.githubusercontent.com/103961256/167728461-bf570a23-5af2-4df6-9b69-ed65fa00e468.PNG)

## Services
#### Azure Web App Service
 - Why: I Used an app service for its ease of use in hosting my website that is publicly accessible. It is able to manage multiple different frameworks and different programming languages (used mainly HTML and C# for mine). 
 - Purpose: The purpose for my app service was to be able to allow anyone to access the Indiana Tech 2022 Baseball statistics easily in a very user-friendly way, and the app service, with its built-in frameworks, allowed for ease of publishing to the web, what I intended. 
#### Azure App Service Plan
 - Why: The app service plan is created for the web app to run since it defines computer resources for it.
 - Purpose: The purpose of the app service plan is to define the operating system, region, pricing tier, etc. Basically, the app service plan determines my features of my app service and how much to pay for those features I have chosen. 
#### Azure SQL Database
 - Why: The SQL database is a relational database service to hold tables, data, and ultimately pull queries. 
 - Purpose: The purpose of the SQL database is to be able to pull the query defined to the web app for users to see and then be able to add data, edit, and delete the data as they, so please. Data can be added from both front-end (by the public user) and back-end (by an admin - like me). Main purpose of accessing, updating, and maintaining data. 
#### Azure SQL Server
 - Why: The SQL server is the SQL databases' management system to support the many analytics, transaction, and business intelligence operations behind the scenes. 
 - Purpose: The SQL server's purpose is to be the database engine to the SQL database and control data storage and help execute my queries for the database. 

## Azure Well-Architected Framework
#### Reliability
- My services are quite reliable since I have made many Geo-redundant services (SQL Database/Server), which provide high availability and durability for hosting data and the application implemented. This ensures that it will be reliable even in the event of an outage, where data is synchronously replicated in the primary region and also asynchronously replicated to a secondary region that is far away.
#### Security
- My services are quite secure since my SQL Database, Server, and connection string all have credentials to gain access to them. The web page is also quite secure since it is running on HTTPS (Hypertext Transfer Protocol Secure). This allows for a very protected and confidential user experience when accessing the web app but also against those who intend to do malicious things. Additionally, the server firewall only accepts client IP addresses. 
#### Cost Optimization
- I have managed my costs very effectively for the value being delivered. For my SQL Database/Server, I have an estimated monthly cost of $4.99/month using the Basic service tier due to the less demanding workload.  For my app service/app service plan, I am currently using the Free pricing tier, which allows for up to 1 GB of memory and 60 mins/day compute at no charge, which is great for the minimal workload on the web app service. 
![CC 8](https://user-images.githubusercontent.com/103961256/167781799-27a58cfa-30f3-4914-957c-c70928dc580a.PNG)
- ^ Shown above is the running cost of this app since deployment May 8th-11th, 2022
#### Operational Excellence
- In terms of the operational excellence side of things, the services and processes I have implemented creates an environment where the applications running remain in production. They are very reliable and predictable since it is using a simple two-tier model with not many moving parts. Nothing really slows down any of the processes with the resources I have deployed for this project. 
#### Performance Efficiency
 - The performance efficiency is great for the computing power that needs to be done between the SQL side of things as well as the front-end web app service side. It takes very little computing power to run what I am running - mainly filling tables of data from different sources (web app and SQL Database). The entire project is quite efficient in its performance and has the ability to be edited or even torn down and republished perfectly at a moment's notice. 
![CC 9](https://user-images.githubusercontent.com/103961256/167782440-2555893f-43bc-4fe8-a98f-38ff2fddb38a.PNG)
- ^ Shown above is the App Service Plan Compute Analytics
## Automation
- In terms of Automation, First, I was able to link the Virtual Studio Project to the Virtual Studio Code Project. Then, I was able to push the Virtual Studio Code to my repository by going to the Source Control icon, clicking on Initialize Repository, and then pushing to the URL of my Github repository.
- I was then able to use the Azure portal to help in automation by deploying my app through Github Actions. I achieved this by going through the Deployment Center in the Azure Portal to find the automation option of Github. It then proceeded to create a Github Action workflow with code to deploy my project on push in the master branch.
- Currently, I am troubleshooting a runtime time when deploying the project automatically. I have done extensive research on the cause of my error message and have tried multiple solutions with no success. I believe it is a .Net Framework issue of compatibility. It seems to be a common issue with little to no standardized solutions. I will continue to troubleshoot this problem in order to achieve automation fully. I plan on doing some more research and using a trial and error method like I have been doing.
- Nonetheless, all the code I have used for Virtual Studio and my resource group's JSON file is under the master branch for your consideration.
![CC 10](https://user-images.githubusercontent.com/103961256/168485036-8600962a-3f6a-4dbd-ac8c-9403b592d15d.PNG)
- ^ Error message from Github Actions Logs.
#### Possible Problems Needed to Investigate Further (from conducting research):
- Attempting to build a .Net 6.0 project on a container that doesn't have .Net 6.0 SDK installed, or on a container where global.json was used to switch to the .Net Core 3 SDK. If this is it, I need to implement .Net 6.0 SDK across all platforms for standardized and seamless transition
- Minimum version required for the SDK version is not up to par. Need to implement to a higher version. 
- Use the preview release for visual studio 16.8.0 Preview 3.0. to get past this issue
## Future Revisions
 - For future revisions, I would add functionality to the add pitcher, edit, and delete buttons and brush up on my HTML codding experience by being able to have the public user-editable and writable data from the SQL database within the web app. If I had more time, I would have experimented with this and did additional research on how to make this work in order to update the back-end SQL database using the front-end web app as originally envisioned. 
 - I would also like to make it more aesthetically appealing by adding logos, sponsors, ads, etc., into the web page and not just have it entirely a functional web page but more appealing and enjoyable to view for the user. 
 - Additionally, to make the website more complete in nature, I would add a schedule that would also link to a SQL database with the entire season schedule with the ability to edit scores and results of games. 
 - I should add the logging feature to my azure services to collect and analyze performance based data from the services I am running. It will help me track the performance efficiency and availability of my cloud resources. 
 - I should also add the monitoring feature to my project to collect, analyze, and act on my environment. This will help me better aid in application performance as well as identifying issues as they happen and get to the root of the problem as soon as possible. This can also be paired with alerts to be notified in the event something happens and/or parameters set by the administrator.
 - Laslty, I should add backup feature to my services. This will ensure that the data can be recovered if the service happens to crash so data is not lost. I would have it configured on a schedule where it backs up every seven days and deletes the previous backup when a new one is stored. 
- Looking back at things, since I am using a rather simple SQL query pull, I should use table storage to keep my costs and overhead lower compared to what it is now. It would take much less compute/storage power to produce the same fields. 
## Summary & Takeaways
- Lastly, I am very proud of myself for completing this project. I feel like I gave it my all and used my resources very effectively, and learned a lot along the way. I had never used many cloud-based services before, and seeing how everything works from a configuration/back-end perspective was definitely great exposure! I do recommend this class to all Computer Science (or related field program) undergrads as there is a lot to learn with the way the world of technology is headed to a more cloud-based model.
- I have learned a lot from failing many times, especially in the early stages but also throughout the entire project. In the beginning, for example, I was very frustrated that I wasn't even able to connect my SQL database to my ASP.NET web app. Overall, this took a lot of trial and error, never giving up/quitting, and resilience - things we talk about on the baseball field that our great coaches stress every day when it comes to athletic competition but in a broader sense -  life.
- I am impressed I was able to code my web app entirely by myself using HTML, which I had to brush up on my skills, as well as C#, which I had almost no experience in. I am also impressed by how well I used the .Net framework in Visual Studio and Razor Pages. All of these skills I learned and implemented through research came in very handy for the success of my web app and final product.
- Thanks for your time in reading about my project!
