
# CMPG 323 Project 3 - TelemetryPortal_MVC
This project enhances an existing web application to manage project and client data by implementing coding principles, design patterns, and best practices.

## Technology Stack
- **Framework:** ASP.NET Core MVC
- **Programming Language:** C#
- **Database:** SQL Server
- **Development Tools:** Visual Studio 2022, .NET 8 SDK
- **Cloud Hosting:** Azure (App Service)

## Getting Started

### Prerequisites:
1. **Access to NWU Azure tenant**: Log in using NWU Microsoft account (`12345678@mynwu.ac.za`).
2. **Visual Studio 2022 Community Edition**: Ensure that Visual Studio and .NET 8 SDK are installed on thw machine.
3. **Database**: Ensure the SQL Server database is up and running.

### Setup Instructions:
1. Clone or download the project from the GitHub repository.
2. Open Visual Studio 2022.
3. **If you don’t see the TelemetryPortal_MVC project:**
   - Navigate to the **Windows** tab at the top.
   - Select **Reset Window Layout**.
   - After this, double-click on the `TelemetryPortal_MVC` solution file to open the project components.
4. **Add Database Connection:**
   - The `appsettings.json` file in the root directory is modifies to include the SQL Server connection string for data access.

### How to Run:
1. **Open TelemetryPortal_MVC**: Once Visual Studio is open, double-click the `TelemetryPortal_MVC` solution file to view the full project.
2. **Run the Project**: Press `F5` or click on the green run button in Visual Studio to start the web application.

## Project Features:
This project focuses on managing CRUD operations for both **Projects** and **Clients**.

- **Project Data**: Includes features to create, update, delete, and view project details.
- **Client Data**: Includes features to create, update, delete, and view client details.
- **Design Patterns**: Implements the Repository Pattern to separate data access from the logic in controllers.
- **Security**: Ensures no sensitive credentials are stored in the GitHub repository.
- **Cloud Hosting**: The application can be deployed to an Azure App Service.

## Repository Pattern Implementation
The project follows the repository pattern:
- **Project Repository**: Handles data access for project-related information.
- **Client Repository**: Manages data access for client-related operations.
- Data operations from the controllers have been transferred to their respective repository classes to maintain separation of concerns.

## Deployment
The application can be published on Azure using an App Service (F1 tier). This ensures scalability and ease of access, the steps below have been used to deploy my API:
1. Create an Azure App Service.
2. Publish the project from Visual Studio by connecting to your Azure subscription.
3. Ensure proper security configurations are in place.

## Reference List
1. Acharya, S. (2024). *Architectural Patterns in .NET*. C# Corner. Retrieved from https://www.c-sharpcorner.com/uploadfile/babu_2082/architectural-patterns-in-net/

2. Kaushik, M. (2024). *Design Patterns in .NET*. C# Corner. Retrieved from https://www.c-sharpcorner.com/UploadFile/bd5be5/design-patterns-in-net/

3. Microsoft. (2024). *ASP.NET MVC Overview*. Retrieved from https://learn.microsoft.com/en-us/aspnet/mvc/overview/older-versions-1/overview/asp-net-mvc-overview

4. Microsoft. (2024). *Build Web Apps with ASP.NET Core for Beginners*. Retrieved from https://learn.microsoft.com/en-us/training/paths/aspnet-core-web-app/

5. Code Maze. (2024). *Using the Repository Pattern in ASP.NET Core*. Retrieved from https://code-maze.com/using-repository-pattern/

6. Microsoft. (2024). *Secure a .NET Web App with ASP.NET Core Identity*. Retrieved from https://learn.microsoft.com/en-us/learn/modules/secure-aspnet-core-identity/

7. Microsoft. (2024). *Modules for Building Web Apps in ASP.NET Core*. Retrieved from https://docs.microsoft.com/en-us/learn/modules/build-web-apps-with-aspnet-core/

8. Microsoft. (2024). *Introduction to ASP.NET Core Identity Framework*. Retrieved from https://docs.microsoft.com/en-us/learn/modules/secure-aspnet-core-identity/

9. Soni, D. (2024). *Repository Pattern in ASP.NET Core*. Stack Overflow. Retrieved from https://stackoverflow.com/questions/what-is-repository-pattern-in-asp-net-core

10. Rahman, M. (2023). *Best Practices for Repository Pattern in ASP.NET Core*. C# Corner. Retrieved from https://www.c-sharpcorner.com/article/design-patterns-in-net/

11. Microsoft Learn. (2024). *Architecting Modern Web Applications with ASP.NET Core and Azure*. Retrieved from https://learn.microsoft.com/en-us/dotnet/architecture/modern-web-apps-azure/

12. Microsoft Docs. (2024). *ASP.NET MVC Overview*. Retrieved from https://learn.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/getting-started

13. YouTube. (2024). *ASP.NET MVC Tutorial for Beginners*. Retrieved from https://www.youtube.com/watch?v=_5iD4efyeE8

14. YouTube. (2024). *Advanced MVC Techniques*. Retrieved from https://www.youtube.com/watch?v=VYvgmMkGUfc

15. YouTube. (2024). *Repository Pattern in ASP.NET Core*. Retrieved from https://www.youtube.com/watch?v=-Xn7i_BcKJg

16. YouTube. (2024). *Building Web Apps in ASP.NET Core*. Retrieved from https://www.youtube.com/watch?v=KBaDCPl9gM4&t=942s

17. YouTube. (2024). *Web API Development with ASP.NET Core*. Retrieved from https://www.youtube.com/watch?v=lk-GqtZY8Dc

18. Stack Overflow. (2024). *Understanding Repository Pattern in ASP.NET*. Retrieved from https://stackoverflow.com/questions/understanding-repository-pattern-in-asp-net

19. Microsoft Developer Blogs. (2024). *Design Patterns in Web API with ASP.NET Core*. Retrieved from https://devblogs.microsoft.com/design-patterns-in-asp-net-core-web-api

20. LinkedIn Groups. (2024). *ASP.NET Core Development*. Retrieved from https://www.linkedin.com/groups/aspnet-core-development


