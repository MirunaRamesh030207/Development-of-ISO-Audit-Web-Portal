Development of ISO Audit Web Portal

📌 Overview

The Development of ISO Audit Web Portal is a web-based complaint and audit management system developed during my internship at CVRDE (Combat Vehicles Research & Development Establishment), DRDO.

The portal digitizes the process of managing ISO audit complaints by replacing manual reporting with a centralized platform. It enables users to submit complaints, track their status, and allows administrators to efficiently monitor, manage, and resolve issues through an interactive dashboard.

---

🚀 Features

- User Authentication and Authorization
- Complaint Registration
- Complaint Status Tracking
- CRUD Operations (Create, Read, Update, Delete)
- Role-Based Access Control
- Admin Dashboard
- Complaint Reports
- Responsive User Interface

---

🛠️ Tech Stack

Frontend
- HTML
- CSS
- JavaScript
- Bootstrap

Backend
- ASP.NET Core MVC
- C#

Database
- SQL Server / MySQL

IDE
- Visual Studio 2026

---

📂 Project Structure

```
Development-of-ISO-Audit-Web-Portal
│
├── Controllers/
├── Models/
├── Views/
├── wwwroot/
├── Properties/
├── Database/
│   └── ISO_Audit_Web_Portal.sql
├── appsettings.json
├── Program.cs
├── PROJECT_CVRDE_FINAL.csproj
└── README.md
```

---

⚙️ Installation

1. Clone the Repository

```bash
git clone https://github.com/MirunaRamesh030207/Development-of-ISO-Audit-Web-Portal.git
```

2. Open the Project

Open the solution/project using Visual Studio 2026.

3. Configure the Database

- Open SQL Server Management Studio (or MySQL Workbench).
- Create a new database.
- Execute the SQL script located inside the Database folder.

4. Configure Connection String

Update the connection string inside:

```
appsettings.json
```

Example:

```json
"ConnectionStrings": {
    "DefaultConnection": "Your Connection String"
}
```

5. Run the Application

Press F5 or click Start in Visual Studio.

---

🗄️ Database

The SQL script includes:

- Database Creation
- Table Creation
- Primary Keys
- Foreign Keys
- Sample Data

Location:

```
Database/ISO_Audit_Web_Portal.sql
```

---

📸 Screenshots

You can add screenshots of:

- Login Page
- Dashboard
- Complaint Registration
- Complaint List
- Complaint Details
- Reports

Store them inside:

```
Screenshots/
```

---

🎯 Project Objectives

- Digitize ISO audit complaint management.
- Improve complaint tracking.
- Reduce manual documentation.
- Increase workflow efficiency.
- Provide centralized audit management.

---

👨‍💻 Developed By

Miruna Ramesh
Monishaa S

B.Tech Computer Science and Business Systems

Panimalar Engineering College

GitHub:
https://github.com/MirunaRamesh030207

---

📄 License

This project was developed for educational and internship purposes.
