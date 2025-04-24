# 🐾 PetPals – Pet Adoption Management System

**PetPals** is a comprehensive desktop-based Pet Adoption and Foster Care Management System built using **Visual C# (Windows Forms)** for the front end and **Oracle SQL+** as the backend database. It aims to digitize and streamline the workflows of animal shelters and rescue organizations by providing centralized access to pet profiles, adoption tracking, foster care, and sponsorship management.

---

## 📌 Table of Contents

- [Overview](#overview)
- [Features](#features)
- [Technology Stack](#technology-stack)
- [System Architecture](#system-architecture)
- [Installation](#installation)
- [Usage](#usage)
- [Screenshots](#screenshots)
- [Team](#team)
- [License](#license)

---

## 📖 Overview

**PetPals** offers a role-based platform that supports structured pet profile management, adoption tracking, foster care coordination, and real-time data access for authenticated users. The system is designed for use by shelter staff, adopters, foster parents, and sponsors.

By leveraging **Oracle ODP.NET**, PetPals ensures fast, reliable, and secure communication with the Oracle database.

---

## 🌟 Features

- 🐶 **Centralized Pet Management**: Store and update detailed profiles for every pet, including medical history, behavior, and availability.
- 🧑‍💻 **Secure Role-Based Access Control**: Authenticate adopters, foster parents, and shelter admins through verified registration and login.
- ✅ **Adoption Workflow Automation**: Track applications, manage approvals, and record post-adoption data.
- 🏡 **Foster Care Management**: Assign foster homes, monitor pet well-being, and handle sponsorships and donations.
- 📊 **Insightful Reporting**: Generate analytical reports on adoptions, health records, and shelter statistics.
- ⚙️ **Reliable Backend Connectivity**: Oracle ODP.NET integration for optimized database interactions.

---

## 🛠️ Technology Stack

- **Frontend**: Visual C# (Windows Forms)
- **Backend**: Oracle SQL+ Database
- **Data Access**: Oracle ODP.NET
- **IDE**: Visual Studio 2022 / Oracle SQL Developer

---

## 🧱 System Architecture

```mermaid
graph TD;
    User[End Users: Admins, Adopters, Foster Parents] -->|Input Data| CSharpUI[Visual C# Windows Forms];
    CSharpUI -->|ODP.NET| OracleDB[(Oracle SQL+ Database)];
