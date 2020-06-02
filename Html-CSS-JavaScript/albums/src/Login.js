import React, {Component} from 'react';
import Button from '@material-ui/core/Button';
import firebase from './initializers/firebase'
import Avatar from '@material-ui/core/Avatar'
import {withStyles} from '@material-ui/core/styles'
import IconButton from '@material-ui/core/IconButton'
import ExitToApp from '@material-ui/icons/ExitToApp'

class Login extends Component {
    constructor(props) {
        super(props);
        this.login = this.login.bind(this);
        this.state = {
            userLoggedIn: false,
            photoUrl: ""
        }
    }

    componentDidMount() {
        firebase.auth().onAuthStateChanged((user) => {
            if (user) {
                //Inicio Sesion
                this.setState({
                    userLoggedIn: true,
                    photoUrl: user.providerData[0].photoURL
                })
            } else {
                this.setState({
                    userLoggedIn: false,
                    photoUrl: ''
                })
            }
        })
    }

    login() {
        let provider = new firebase.auth.GoogleAuthProvider();
        provider.addScope("https://www.googleapis.com/auth/photoslibrary.readonly");
        firebase.auth().signInWithPopup(provider).then(result => {
            //console.log(result.credential.accessToken);
            let Token = result.credential.accessToken;
        }).catch(err => {
            console.log(err);
        })

    }

    logout() {
        firebase.auth().signOut().then(console.log);
    }

    showButtonLogin() {
        if (this.state.userLoggedIn) {
            return ([<Avatar src={this.state.photoUrl}></Avatar>,
                (<IconButton color={"inherit"} onClick={this.logout}> <ExitToApp></ExitToApp></IconButton>)]);
        } else {
            return (
                <Button variant="contained" onClick={this.login}>
                    Iniciar Session Google
                </Button>
            );
        }
    }

    render() {
        return (
            <div className={this.props.classes.container}>
                {this.showButtonLogin()}
            </div>
        )
    }
}

export default withStyles({
    container: {
        display: 'flex',
        flexDirection: 'row'
    }
})(Login);