# Paint-Calculator

Paint Calculator - A solution for [borwell's software challenge](https://borwell.com/software-challenge/)

## Task

### Purpose

The purpose of this software challenge is to give you an opportunity to showcase how you think code should be written. It should be a demonstration of your skills and opinions.

### Instructions

- The solution should be completed using a TDD approach
- Consider the use of comments where appropriate
- Ensure your code is clean and readable. We value readable code over “clever” solutions
- Ensure your solution contains a README with instructions on how to build and run your application
- Your submission should be in the form of a Git repository
    - You should use Git tooling to provide a granular commit history
- You are free to use whatever tools, libraries, and frameworks that you see fit
    - Prefer using technologies relevant to the role. For example, using web technologies for a web role
- Don’t be shy to showcase your DevOps enthusiasm or experience!
- State any assumptions made
- Limit your time to 4 hours, and explain what you would refine if you had more time on the project

### Scenario

Write a program that takes as input the dimensions of a room and outputs the following:

- Area of the floor
- Amount of paint required to paint the walls
- Volume of the room

## Solution

Using the task above, I built a website that calculates the requirements above using the dimensions of a room.

For this I used:
- [Docker](https://www.docker.com/) (created a Dockerfile and docker-compose file)
- [C#](https://learn.microsoft.com/en-us/dotnet/csharp/)
- [Blazor](https://dotnet.microsoft.com/en-us/apps/aspnet/web-apps/blazor)
- HTML and CSS
- [Bootstrap](https://getbootstrap.com/docs/5.1/getting-started/introduction/)

I decided on the technologies above as I wanted to focus on the latest and upcoming technologies compared to writing a winforms or text-based application, which although may look or be better, wouldn't show of my skills.

## Project Structure

Main Files:
- Startup.bat: runs the docker-compose file
- Source\Paint-Calculator\docker-compose.yaml: the docker-compose file used to build the image and create the container
- Source\Paint-Calculator\Paint-Calculator\Dockerfile: the dockerfile with the instructions to build the image
- Source\Paint-Calculator\Paint-Calculator\Pages\Index.razor: the main razor file with the HTML in
- Source\Paint-Calculator\Paint-Calculator\Data\FormProcessesingService.cs: the main C# Blazor file that runs the calculations
- Source\Paint-Calculator\Paint-Calculator\Data\FormModel.cs and Source\Paint-Calculator\Paint-Calculator\Data\ReturnModel.cs: the models for the data transmission objects

## Installation and Setup

Step 1: Clone this repository
Step 2: Install [docker](https://docs.docker.com/engine/install/) if you haven't already
Step 3: Run the Startup.bat script or run the docker-compose.yaml file using `docker-compose up -d`
Step 4: Open https://localhost:8082

## Improvements

If I had more time, I would have:
- Connected it to a database
- Made it work with more complex room shapes
- Improved UI/UX (not a strong point of mine)
- Commented the CSS files

## Screenshots
See the screenshot folder