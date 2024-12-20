# Bank System (Newest Hands-on Project)

## Overview
The Bank System is a scalable and efficient banking application designed to manage core banking functionalities. 
It provides essential services such as user management, client accounts, transactions, currency exchange, and balance inquiries. 
This project showcases my skills in backend development, API design, and adherence to clean coding principles.

---

## Features
- **User Management**: Registration, login, and account management with role-based access control.
- **Client Accounts**: Create and manage client accounts efficiently.
- **Transactions**: Handle deposits, withdrawals, and transfers with real-time balance updates.
- **Currency Exchange**: Support for currency exchange transactions(Using Online Web API).
- **CRUD Operations**: Comprehensive RESTful APIs for all banking entities including Users, Clients, Accounts, Transactions, and Transfer Logs.

---

## Architecture
- **Backend Architecture**: 
  - **3-Tier Architecture**:
    - **API Layer**: Exposes RESTful APIs to handle client requests.
    - **Business Logic Layer**: Handles the communication between the Data Access Layer and the API Layer.
    - **Data Access Layer**: Manages interactions with the database.

- **Frontend Architecture**: 
  - **2-Tier Architecture**:
    - **Presentation Layer**: User interface for client interactions.
    - **Data Access Layer**: Handles communication with the backend APIs.
      
- **Database**: 
  - Designed using SQL with a focus on relational database principles to ensure data integrity and scalability.
  - Developed optimized stored procedures for complex queries, improving execution time and system performance.
  - Incorporated primary and foreign keys to ensure referential integrity and support relationships between entities (e.g., Users, Clients, and Accounts).
  - Used indexing and query optimization techniques to enhance database performance.

---

## Code Quality
- Modular and well-documented code for better readability and maintainability.
- Adhered to clean coding principles to ensure a high standard of code quality.

---

## Technologies Used
- **Programming Languages**: C#
- **Framework**: ASP.NET core Web API (Backend), Windows Forms App (Frontend)
- **Architecture**: 3-Tier (Backend) and 2-Tier (Frontend)
- **API Design**: RESTful APIs
- **Database**: MS SQL Server, ADO.NET
