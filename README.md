# 🌐 RequestResponseLogger (ASP.NET Core Middleware)

## 🎯 Overview
A custom ASP.NET Core middleware that logs every HTTP request and response details into a text file for monitoring and debugging.

## ⚙️ Features
- ✅ Logs each incoming HTTP request:
  - Timestamp
  - Method (GET/POST/PUT/DELETE)
  - Path (e.g., `/weatherforecast`)
  - Request headers (Host, User-Agent, Content-Type, Accept)

- ✅ Logs each HTTP response:
  - Status code
  - Response headers (Date, Server, Content-Type, Cache-Control)

- ✅ Stores logs in `Logs/RequestResponseLog.txt`

## 📸 Screenshots

### 1. Middleware Code
<img width="1680" height="1050" alt="image" src="https://github.com/user-attachments/assets/de0b9f16-703e-461e-b1cc-94f59b4755b9" />

### 2. Running the API (Swagger UI)
<img width="3360" height="4164" alt="Swagger" src="https://github.com/user-attachments/assets/7605086a-8e02-4e15-bb8d-cadc18dd9c13" />


### 3. Generated Logs
Screenshot of `Logs/RequestResponseLog.txt` showing a clean `200 OK` log entry captured by middleware.
<img width="1680" height="1050" alt="image" src="https://github.com/user-attachments/assets/d2dac821-ae62-4fbe-8e83-dc60db2e2567" />



## 🚀 Run Locally

1. Clone the repository:
   ```bash
   git clone https://github.com/NumaAli/AspNetCoreRequestLogger.git
   cd AspNetCoreRequestLogger
   Run the project:
   dotnet run
   

### Author
```markdown
## 🧑‍💻 Author
- Name: Numa Rahim  
- GitHub: https://github.com/NumaAli
- Project Repo: https://github.com/NumaAli/AspNetCoreRequestLogger 



