import * as React from "react";
import { connect } from "react-redux";

const HomePage = () => (

    <div className="mt-5">
        <h1>Patterns.CSharp</h1>
        <p>
            Sample cross-platform app that is built to demonstrate 23 GoF design patterns via C# using simplistic samples.
        </p>
        <hr />
        <p>
            The application is built using the
            <a href="https://docs.microsoft.com/en-us/aspnet/core/web-api/?view=aspnetcore-3.1" target="_blank" rel="noopener noreferrer"> ASP.NET Core API
            </a> and
            <a href="https://docs.microsoft.com/en-us/aspnet/core/client-side/spa/react-with-redux?view=aspnetcore-3.1" target="_blank" rel="noopener noreferrer"> React-with-Redux project template
            </a> from Visual Studio with:
        </p>
        <ul>
            <li><a href="https://facebook.github.io/react/" target="_blank" rel="noopener noreferrer">React</a>,
                <a href="https://redux.js.org/" target="_blank" rel="noopener noreferrer"> Redux</a> and
                <a href="https://www.typescriptlang.org/docs/handbook/basic-types.html" target="_blank" rel="noopener noreferrer"> TypeScript</a> for client-side code</li>
            <li><a href="https://react-bootstrap.github.io/components/alerts" target="_blank" rel="noopener noreferrer">React Bootstrap</a> for layout and styling</li>
        </ul>
        <p>Important:</p>
        <ul>
            <li>All of the Patterns are located in the <code>Patterns</code> subdirectory.</li>
            <li>The <code>PatternUseCase</code> type and the <code>UseCase</code> type are related to none of the patterns.</li>
            <li>The above types were created to deliver the output to your browser when you run the app and select a pattern.</li>
        </ul>
        <p>
            The <code>ClientApp</code> subdirectory is a standard React application based on the <code>create-react-app</code> template.
            If you open a command prompt in that directory, you can run <code>npm</code> commands such as <code>npm test</code> or <code>npm install</code>.
        </p>
        <p>Click the &ldquo;Patterns&rdquo; navigation bar item and use dropdowns to select a pattern.</p>
    </div>

);

export default connect()(HomePage);