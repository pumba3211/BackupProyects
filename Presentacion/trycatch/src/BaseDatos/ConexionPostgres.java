/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package BaseDatos;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

/**
 *
 * @author ronald
 */
public class ConexionPostgres {

    public Connection Conection; //Tipo de dato de conexion de Base de datos 

    public ConexionPostgres(String pBD, String pUser, String pPass, String pHost, String pPort) throws ClassNotFoundException, SQLException {
        try {
            //Driver de conexion , en este caso es postgres
            String driver = "org.postgresql.Driver";
            Class.forName(driver);
            //Se crea el string de conexion a la pase de datos por los parametros
            String connecString = "jdbc:postgresql://" + pHost + ":" + pPort + "/" + pBD;
            //Se intenta establecer conexion a la base de datos
            this.Conection = DriverManager.getConnection(connecString, pUser, pPass);
            System.out.println("Conexcion realizada con exito");

        } catch (SQLException e) {
            System.out.println("Error al conectarse: " + e.toString());
        }
    }
}
