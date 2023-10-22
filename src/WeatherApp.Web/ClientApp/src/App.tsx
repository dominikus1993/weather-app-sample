import React, { useState } from 'react';
import logo from './logo.svg';
import './App.css';

function App() {
    
  let [count, setCount] = useState(0);

  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <p>
          Edit <code>src/App.tsx</code> and save to reload.
        </p>
        <a
          className="App-link"
          href="https://reactjs.org"
          target="_blank"
          rel="noopener noreferrer"
        >
          Learn React
        </a>
      </header>
      <button onClick={() => setCount(count + 1)}>+</button>
      <p>{count}</p>
    </div>
  );
}

export default App;
