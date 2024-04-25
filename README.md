## ASAP_Clients API: Read Me

**Description**

ASAP_Clients is a web application API designed for managing client data and providing stock market data notifications. The API offers a comprehensive suite of functionalities for:

* **Client Management:**
    * Create new client entries.
    * Edit existing client information.
    * Delete client records.
    * Retrieve a list of all clients or specific client details.
* **Market Data Integration:**
    * Leverages the Polygon.io service (**PolygonService**) to fetch real-time closing stock price data for user-specified tickers at configurable intervals.
    * Stores the retrieved data securely within the application's database.
* **Client Notification System:**
    * Utilizes the **Clients.Mail Service** to notify clients via email with the latest fetched stock price data.

This API empowers users to establish a central repository for client information while streamlining the process of acquiring and disseminating crucial stock market data.

**Key Features:**

* RESTful API architecture for seamless integration.
* Secure client data management.
* Automated stock price data fetching and storage.
* Email notification system for timely updates.

**Technology Stack:**

* **API Development:**
    * .NET 8 (compatible with .NET runtime environment)
    * C# for efficient and modern application development
* **Database:**
    * Microsoft SQL Server 2022 (other compatible versions may be used)
* **External Services:**
    * Polygon.io API for stock market data retrieval (requires a valid API key)
* **Email Notifications:**
    * Requires a designated email account to send notifications (credentials stored in appsettings.json)

**Configuration:**

The API utilizes a configuration file (appsettings.json) for various settings:

* **Database Connection String:** Defined within each service's appsettings.json for database connectivity.
* **Polygon.io API Key:** Specified in the PolygonService's appsettings.json for authentication with the external service.
* **Client Email Notification Settings:** Configured within the Clients.Mail Service's appsettings.json under the 'SMTP' section. This includes email server details and credentials.
* **Data Fetching Interval:** Set within the appsettings.json under the 'Polygon' section to determine the frequency of stock price data retrieval.
* **Email Sending Interval:** Defined within the appsettings.json under the 'Mail' section to control the schedule of client notifications.

**Deployment Considerations:**

* **Service Ports:** The ports for each of the three services (Clients.Service, PolygonService, Clients.Mail Service) are specified in the launchsettings.json file located within the 'Properties' folder. Ensure these ports are properly configured during deployment.
* **Firewall Rules for Email Delivery:** When deploying the application on a server with a firewall, configure rules to allow outbound connections on the designated SMTP port using the SSL/TLS protocol. This is essential for the Clients.Mail Service to send email notifications successfully.

**API Endpoints (Clients.Service):**

The following API endpoints are exposed by Clients.Service, accessible via a RESTful interface:

**1. Get All Clients:**

* **URI:** `/api/Client`
* **Method:** GET
* **Response:** Returns a JSON array containing all client objects (ClientDto).

**2. Get Client by ID:**

* **URI:** `/api/Client/{clientID}`
* **Method:** GET
* **Path Parameters:**
    * `{clientID}`: The unique identifier of the client to retrieve.
* **Response:** Returns a JSON object representing the specified client (ClientDto) or an error message if not found.

**3. Create Client:**

* **URI:** `/api/Client`
* **Method:** POST
* **Request Body:** JSON object representing the new client data (UpdateClientDto). Refer to the schema definition for required and optional properties.
* **Response:** Success status code (e.g., 200) upon client creation.

**4. Update Client:**

* **URI:** `/api/Client/{clientID}`
* **Method:** PUT
* **Path Parameters:**
    * `{clientID}`: The unique identifier of the client to update.
* **Request Body:** JSON object containing the updated client information (UpdateClientDto). Refer to the schema definition for required and optional properties.
* **Response:** Success status code (e.g., 200)  upon client update.

**5. Delete Client:**

* **URI:** `/api/Client/{clientID}`
* **Method:** DELETE
* **Path Parameters:**
    * `{clientID}`: The unique identifier of the client to delete.
