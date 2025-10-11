# 🧩 Letz-Eight Backend

Welcome to the **Letz-Eight Backend** project!

This repository contains the API that powers the Letz-Eight application. Follow the instructions below to set up and run the project locally.

---

## 🚀 Getting Started

### 1. Navigate to the API project

Open your terminal and move into the API project directory:

```bash
cd ./src/Presentation/LetzEight.Api
```

### 2. Run the application

You can launch the API using either **HTTP** or **HTTPS** (recommended):

```bash
# Run with HTTPS (recommended)
dotnet run -lp https

# Or run with HTTP
dotnet run -lp http
```

---

## ℹ️ What is `-lp`?

The `-lp` (short for **launch profile**) option tells .NET which profile from your `launchSettings.json` file to use when starting the application.

- `https` → Runs the app using the HTTPS profile (recommended for secure local testing)  
- `http` → Runs the app using the HTTP profile

---

## ✅ Example

To start the API using the HTTPS profile:

```bash
dotnet run -lp https
```

This will start the **Letz-Eight API** using the HTTPS launch profile defined in `launchSettings.json`.

---

## 🔧 Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) installed (use the SDK version matching the project).  
- Recommended: a modern terminal (Windows: PowerShell / Windows Terminal; macOS / Linux: bash or zsh).

---

## 🛠 Common Tasks & Tips

- **Ports already in use**: If the configured port is occupied, edit `Properties/launchSettings.json` to change the port or stop the process using the port.  
- **HTTPS development certificate**: If HTTPS fails locally, run `dotnet dev-certs https --trust` to trust the dev certificate (platform-specific prompt may appear).  
- **Environment variables**: Configure environment values in your local environment or use a `.env` approach if the project supports it.  
- **Run with a different profile**: Use any profile name defined in `launchSettings.json` via `dotnet run -lp <profileName>`.

---

## 🧭 Project Structure (high level)

```
/src
  /Presentation
    /LetzEight.Api        ← API project (run this)
  /Core
    /LetzEight.Domain
    /LetzEight.Application
  /Infrastructure
    /LetzEight.Infrastructure
    /LetzEight.Presistence
```

---

## 🐞 Troubleshooting

- If `dotnet run` fails, check the console error for missing SDK or invalid launch profile name.  
- If HTTPS endpoint is unreachable, verify the HTTPS profile settings in `launchSettings.json` and the dev certificate.  
- If migrations or DB connection issues happen, double-check connection strings and that the DB server is running.

---

## 🤝 Contributing

Contributions are welcome. Please open issues or PRs for bug fixes, features, or documentation improvements.

---

## 📄 License

Add your license information here (e.g., MIT, Apache-2.0) if applicable.

---

**Happy coding! 💻**
