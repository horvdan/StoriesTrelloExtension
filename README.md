# StoriesTrelloExtension

Trello PowerUp for rendering a storyboard

## Prerequisites

* Node+npm (LTS)
* .NET Core 2.2 SDK

## Getting started

Install dependencies:
* Restore Nuget packages for the .NET solution.
* To create to DB, navigate to the `./server/StoriesTrelloExtension` folder and run

```
dotnet ef database update
```

* In the `./ui` folder

```
npm install
```

Start the project:
* Start backend server
* Run `npm start` in the `ui` folder to start the frontend development server
* Open an [ngrok](https://ngrok.com/) tunnel on port `1234`
* Set Trello Iframe connector URL to:

```
https://{id}.ngrok.io/trello.html
```
