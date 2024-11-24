# Alspec

This project is used as an exercise to Alspec, containing small demonstration of creating web application using React JS (Frontend) and ASP.NET Core API (Backend).

## Steps to run the application

### Database
1. Open your database.
2. Execute the provided SQL Script (`/Query to Create Tables and Insert Data.sql`) to create the tables and insert the sample data.

### ASP.NET Core API
3. Open the `api` project using Visual Studio.
4. In the `appsettings.json` file (`DBConnection` section), provide your database information/credentials.
5. In the `appsettings.json` file (`CORS-Settings` section), it has the default React URL of `http://localhost:3000` (if it is not this, you can change here).
6. Start the solution.
7. By default, the API URL will be `https://localhost:7090`.

### React Application
8. Open the `ui` project using Visual Studio Code.
9. In the `.env` file, it has the default API URL of `https://localhost:7090` (if it is not this, you can change here).
10. Open the terminal and refer to this `ui` project location.
11. Type `npm install` to install the node_modules.
12. Type `npm start` to run the application.
13. By default, the URL will be `http://localhost:3000`.
14. Once it is started, it will open the web browser and load the Job API.
 
![image](https://github.com/user-attachments/assets/5656f757-f074-4e0e-b6f8-e8bf4ae79c63)
