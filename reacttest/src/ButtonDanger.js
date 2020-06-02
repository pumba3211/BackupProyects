import React, { Component } from 'react';
import { Button } from 'reactstrap';
class ButtonDanger extends Component {
  onButtonClick() {
    alert("prueba");
  }
  render() {
    return (
      <div>
        <Button outline color="primary" size="lg" onClick={() => this.onButtonClick()}>primary</Button>{' '}
        <Button outline color="secondary" onClick={() => this.onButtonClick()}>secondary</Button>{' '}
        <Button outline color="success" onClick={() => this.onButtonClick()}>success</Button>{' '}
        <Button outline color="info" onClick={() => this.onButtonClick()}>info</Button>{' '}
        <Button outline color="warning" onClick={() => this.onButtonClick()}>warning</Button>{' '}
        <Button outline color="danger" onClick={() => this.onButtonClick()}>danger</Button>
      </div>
    );
  }
}

export default ButtonDanger;