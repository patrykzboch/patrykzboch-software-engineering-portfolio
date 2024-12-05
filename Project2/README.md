# Simple Web Browser in C#

## Overview
The **Simple Web Browser** is a lightweight application developed in C# using Visual Studio. It allows users to send HTTP requests, display HTML content, and manage browsing features such as history and favorites. The browser provides a clean and functional GUI to interact with these features.

## Features
- **HTTP Request and Response Handling**:
  - Send HTTP requests for URLs entered by the user.
  - Display the raw HTML content of the requested pages.
  - Handle and display HTTP response status codes:
    - 200 OK
    - 400 Bad Request
    - 403 Forbidden
    - 404 Not Found
- **Home Page Support**:
  - Set a customizable home page URL.
  - Automatically load the home page upon application startup.
- **Favorites Management**:
  - Add, edit, and delete favorite URLs.
  - Associate names with favorite URLs.
  - Load the favorites list on startup and access pages with a single click.
- **Browsing History**:
  - Maintain a history of visited URLs.
  - Navigate back and forward through browsing history.
  - Access previous pages directly from the history list.
- **Bulk Download**:
  - Retrieve and process multiple URLs from a specified file (default: `bulk.txt`).
  - Display results as a list showing the HTTP status code, the number of bytes retrieved, and the URL.
- **User-Friendly GUI**:
  - Designed with Windows Forms for ease of use.
  - Menus and buttons for intuitive navigation and accessibility.

## Contents
This repository contains:
1. **MainCode**: Folder with all source code files for the project.
2. **Web Browser.exe**: A standalone executable to run the web browser on any compatible Windows system.
3. **README.md**: This file provides an overview of the project.

## Usage
1. **Running the Application**:
   - Double-click on `Web Browser.exe` to launch the browser.
   - Ensure the `.NET Core` runtime is installed on your system for compatibility.
2. **Source Code**:
   - Open the `MainCode` folder in Visual Studio to view or modify the source code.
   - The project was developed using Visual Studio 2022, but it should be compatible with earlier or later versions.
3. **Features**:
   - Set your home page, browse URLs, and manage favorites and history.
   - Use the bulk download feature to process a list of URLs from a file.

## Technical Details
- **Development Environment**:
  - Developed using **Visual Studio 2022** with Windows Forms.
  - Compatible with `.NET Core` for cross-platform support.
- **Implementation Details**:
  - HTTP communication is managed manually within the code (no reliance on the C# WebBrowser class).
  - GUI designed for clarity and functionality, supporting both menus and button-driven actions.

## Limitations
- This browser only displays the raw HTML content of web pages and does not render the graphical layout of websites.

---

Feel free to explore, modify, and provide feedback on this project!


