/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package BaseDatos;

import java.sql.Connection;

/**
 *
 * @author ronald
 */
public class Conexion {

    public Connection Conection;

    public boolean isError;//Se utiliza para comprobar si al hacer una consulta hubo un error

    public String errorDescription;//Se utiliza para mostrar el mensaje de error

    private static Conexion INSTANCE = new Conexion();//Se utiliza para asignar la conexion a la base de datos de manera global

    private Conexion() {
    }

    public static Conexion getInstance() {//Se obtiene la conexion global
        return INSTANCE;
    }

    public void Limpiar() {//Se limpian los valores par una nueva consulta
        this.isError = false;
        this.errorDescription = "";
    }
}
