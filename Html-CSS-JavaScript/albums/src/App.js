import React, { Component } from 'react';
import logo from './logo.svg';
import './App.css';
import { withStyles } from '@material-ui/core/styles'
import AppNav from './components/AppNav'

class App extends Component {
  render() {
    return (
      <div className="App">
       <AppNav></AppNav>
      </div>
    );
  }
}

export default withStyles({
  button: {
    backgroundColor: 'yellow'
  }
})(App);
