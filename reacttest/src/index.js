import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';
import 'bootstrap/dist/css/bootstrap.min.css';
import App from './App';
import ButtonDanger from './ButtonDanger';
import RadioButtons from './RadioButtons'; 
import registerServiceWorker from './registerServiceWorker';

ReactDOM.render(<App />, document.getElementById('root'));
ReactDOM.render(<ButtonDanger />, document.getElementById('button'));
ReactDOM.render(<RadioButtons />, document.getElementById('radiobutton'));
registerServiceWorker();
