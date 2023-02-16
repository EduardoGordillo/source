
import './App.css';
import { BrowserRouter, Redirect, Route, Switch } from 'react-router-dom';
import { useState } from 'react';
import TaskPage from './Pages/TaskPage';

import LoginPage from './Pages/LoginPage';
import RegisterPage from './Pages/RegisterPage';

function App() {
  const [login, setlogin] = useState(false);
  return (
    <BrowserRouter>
      <Switch>
        
        <Route exact path='/loggin' >
          <LoginPage log={setlogin}></LoginPage>
        </Route>
        <Route exact path='/register'>
          <RegisterPage log={setlogin}></RegisterPage>
        </Route>
        <Route exact path='/'>
        {
          login? (<TaskPage></TaskPage>):(<Redirect to='/register'></Redirect>)
        }
        </Route>
      </Switch>

    </BrowserRouter>
  );
}

export default App;
