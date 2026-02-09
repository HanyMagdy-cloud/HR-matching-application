# HR Matching Application

A web-based HR management system built with ASP.NET Core MVC and Entity Framework Core.

This application allows administrators and HR staff to manage employees, competences, roles, and project assignments in a structured and scalable way.

---

## 🚀 Features

### 👤 User & Role Management
- ASP.NET Core Identity integration
- Role-based access control (Admin, HR, Project Manager, Employee, Team Leader)
- Assign roles to users
- Activate / Deactivate users

### 🧠 Competence Management
- Create, edit, and manage competences
- Assign competences to employees
- Track:
  - Proficiency Level (Basic, Intermediate, Advanced)
  - Years of Experience

### 📊 User Competence Overview
- View all users with their competences
- One-row-per-user display
- Professional dashboard UI

### 📁 Project Management
- Create and manage projects
- Define project requirements
- Prepare for employee-to-project matching

---

## 🛠 Technologies Used

- ASP.NET Core MVC (.NET 8)
- Entity Framework Core
- SQL Server / Azure SQL
- ASP.NET Core Identity
- Bootstrap 5
- Bootstrap Icons

---

## 🗄 Database

The application uses:
- Entity Framework Core (Code First)
- Azure SQL Database

Main tables:
- AspNetUsers
- AspNetRoles
- Competences
- UserCompetences
- Projects
- ProjectRequirements

---

## ⚙️ Setup Instructions

1. Clone the repository:

```bash
git clone https://github.com/HanyMagdy-cloud/HR-matching-application.git
