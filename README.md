Development of ISO Audit Web Portal

A web-based complaint and audit management system developed during my internship at Combat Vehicles Research & Development Establishment (CVRDE), DRDO.

The system digitizes the process of reporting, tracking, managing, and resolving ISO-related complaints through a centralized web portal. It provides a structured workflow for users and administrators, reducing manual work and improving complaint monitoring.

Tech Stack

| Technology       | Purpose                   |
| ---------------- | ------------------------- |
| C#               | Backend programming       |
| ASP.NET Core MVC | Web application framework |
| HTML             | Page structure            |
| CSS              | Styling                   |
| JavaScript       | Client-side functionality |
| Bootstrap        | Responsive UI             |
| MySQL            | Database management       |
| Visual Studio    | Development environment   |

Features

* User complaint submission
* Complaint tracking and status management
* Administrator dashboard
* Complaint assignment and monitoring
* Complaint resolution workflow
* Database-driven complaint management
* Responsive web interface
* MVC-based application architecture
* Centralized record management

System Architecture

```text
                ISO Audit Web Portal
                         |
              +----------+----------+
              |                     |
            User                Administrator
              |                     |
       Submit Complaint       Manage Complaints
              |                     |
              +----------+----------+
                         |
                    ASP.NET Core MVC
                         |
              +----------+----------+
              |                     |
          Controllers            Models
              |                     |
              +----------+----------+
                         |
                       Views
                         |
                    MySQL Database
```

Project Structure

```text
Development-of-ISO-Audit-Web-Portal/
│
├── Controllers/
│   └── Application Controllers
│
├── Models/
│   └── Application Models
│
├── Views/
│   └── Razor Views
│
├── Properties/
│
├── wwwroot/
│   ├── css/
│   ├── js/
│   └── other static files
│
├── Program.cs
├── appsettings.json
├── appsettings.Development.json
├── PROJECT_CVRDE_FINAL.csproj
└── README.md
```

Database

The application uses MySQL for storing and managing application data.

The database is responsible for maintaining information related to:

* User details
* Complaint records
* Complaint status
* Complaint tracking
* Administrative information
* Audit/issue management data

Database Workflow

```text
User
  |
  | Submit Complaint
  v
Complaint Data
  |
  v
MySQL Database
  |
  v
Administrator
  |
  +---- Review
  |
  +---- Assign
  |
  +---- Update Status
  |
  +---- Resolve
  |
  v
Updated Complaint Status
```

> The complete database schema, including tables, columns, relationships, and sample data, can be added to the repository as a `.sql` file.

MVC Architecture

The project follows the **Model-View-Controller (MVC)** architecture.

Model

Handles the application's data and database-related entities.

View

Provides the user interface using Razor Views, HTML, CSS, JavaScript, and Bootstrap.

Controller

Processes user requests, communicates with the models, and controls the application workflow.

```text
       User Request
            |
            v
       Controller
            |
            v
          Model
            |
            v
      MySQL Database
            |
            v
       Controller
            |
            v
          View
            |
            v
      User Interface
```

Installation and Setup

1. Clone the Repository

```bash
git clone https://github.com/MirunaRamesh030207/Development-of-ISO-Audit-Web-Portal.git
```

2. Open the Project

Open the `.csproj` file using **Visual Studio**.

3. Configure the Database

Create the required MySQL database and update the database connection string in:

```text
appsettings.json
```

Example:

```json
"ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=ISOAuditDB;User=root;Password=your_password;"
}
```

4. Restore Dependencies

Restore the required NuGet packages through Visual Studio.

5. Run the Application

Build and run the project using Visual Studio.

The application will open in the browser through the configured ASP.NET Core development server.

Future Enhancements

* Role-based access control
* Email notifications for complaint updates
* Advanced audit reports
* Export reports to PDF/Excel
* Complaint analytics and visualization
* Automated reminder notifications
* Improved dashboard analytics

Project Outcome

The ISO Audit Web Portal provides a centralized digital solution for managing ISO-related complaints and audit issues. It improves transparency, simplifies complaint tracking, and provides administrators with a structured workflow for monitoring and resolving issues.

Developed During Internship

Organization: Combat Vehicles Research & Development Establishment (CVRDE), DRDO

Project: ISO Audit Web Portal

Domain: Web Application Development

Contributors

Miruna Ramesh
Monishaa S

License

This project was developed as part of an internship project at CVRDE, DRDO.
