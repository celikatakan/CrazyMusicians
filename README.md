<h1>Crazy Musicians API</h1>
<p>This is a simple ASP.NET Core Web API project that lets you manage a list of funny musicians. The API supports basic CRUD operations like creating, reading, updating, and deleting musicians. You can also search musicians based on their name, profession, or fun fact.</p>

<h2>API Endpoints</h2>
<ul>
  <li><code>GET /musicians</code>: Get the list of all musicians.</li>
  <li><code>GET /musicians/{id}</code>: Get a specific musician by their ID.</li>
  <li><code>POST /musicians</code>: Create a new musician.</li>
  <li><code>PUT /musicians/{id}</code>: Update an existing musician.</li>
  <li><code>DELETE /musicians/{id}</code>: Delete a musician by their ID.</li>
</ul>

<h2>Search Musicians</h2>
<p>You can search musicians by using the keyword in their name, profession, or fun fact.</p>

<p><strong>Example:</strong></p>
<p><code>GET /search?keyword=funny</code></p>

<h2>Technologies Used</h2>
<ul>
  <li>ASP.NET Core Web API</li>
  <li>C#</li>
</ul>

<h2>How to Run</h2>
<ol>
  <li>Clone this repo.</li>
  <li>Open the project in Visual Studio or any .NET IDE.</li>
  <li>Run the project with <code>dotnet run</code>.</li>
  <li>You can use tools like Postman to test the API requests.</li>
</ol>
