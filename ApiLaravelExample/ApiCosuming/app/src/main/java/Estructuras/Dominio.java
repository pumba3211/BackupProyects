package Estructuras;

import java.sql.Connection;

/**
 * Created by soporte on 06/07/2016.
 */
public class Dominio {
    public String Dominio = "http://192.168.1.114:8000/";

    public  int fabricanteid;

    private static Dominio INSTANCE = new Dominio();//Se utiliza para asignar la conexion a la base de datos de manera global

    private Dominio() {
    }

    public static Dominio getInstance() {//Se obtiene la conexion global
        return INSTANCE;
    }
}
