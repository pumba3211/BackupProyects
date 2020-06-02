import firebase from 'firebase';

const config = {
    apiKey: "AIzaSyA2k60nTmZ6696UldZvYIXZRx8GJwGIKaE",
    authDomain: "reactalbums.firebaseapp.com",
    databaseURL: "https://reactalbums.firebaseio.com",
    projectId: "reactalbums",
    storageBucket: "reactalbums.appspot.com",
    messagingSenderId: "1022237186114"
};

firebase.initializeApp(config);

export default firebase;
