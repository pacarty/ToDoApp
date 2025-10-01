# ToDoApp
Simple Todo Application using Angular frontend and .NET Web API backend.

## Run the application
Use these instructions to get the project up and running.

### Dependencies
You will need:

* [Visual Studio Code](https://code.visualstudio.com/download)
* [.NET 9.0](https://dotnet.microsoft.com/en-us/download)
* [Node.js](https://nodejs.org/en/) (version 22 or later) with npm (version 11.6.1 or later)

### Setup
Follow these steps to get your development environment set up:

  1. Clone the repository
  2. From the root directory, navigate to the `\WebApi` directory:
    ```
    cd WebApi
    ```
    Then build and run the backend by running:
    ```
    dotnet run
    ```
  3. After the backend has started, open another command window in the root directory and navigate to the `\ClientApp` directory:
     ```
	 cd ClientApp
	 ```
    Then restore the required packages by running:
     ```
	 npm install
	 ```
  4. Finally, launch the frontend by running:
      ```
     npm start
     ```

  5. Launch [http://localhost:5149/api/todo](http://localhost:5149/api/todo) in your browser to view the API
  
  6. Launch [http://localhost:4200/](http://localhost:4200/) in your browser to view the UI