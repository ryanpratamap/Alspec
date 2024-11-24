import { HashRouter as Router, Route, Redirect } from "react-router-dom";
import './App.css';
import JobRead from './job/Read';

function App() {
  return (
    <Router>
      <div>
        <Route exact path="/">
          <Redirect to="/job" />
        </Route>
        <Route exact path="/job" component={JobRead} />
      </div>
    </Router>
  );
}

export default App;
