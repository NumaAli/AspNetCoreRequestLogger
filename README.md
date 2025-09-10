# 🌐 ASP.NET Core Middleware 
## 🎯 Overview
This project demonstrates a **custom class-based middleware** in ASP.NET Core that logs every HTTP request and response to a `.txt` file.  

## ⚙️ Features
- ✅ Logs each incoming HTTP request:
  - Timestamp  
  - Method (GET/POST/PUT/DELETE)  
  - Path (e.g., `/weatherforecast`)  
  - Request headers (Host, User-Agent, Content-Type, Accept)  

- ✅ Logs each HTTP response:
  - Status code (200/404/301 etc.)  
  - Response headers (Date, Server, Content-Type, Cache-Control)  

- ✅ Stores logs in `Logs/RequestResponseLog.txt`


