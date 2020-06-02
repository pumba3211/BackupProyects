/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package BaseDatos;

import Clases.Persona;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;

/**
 *
 * @author ronald
 */
public class MetodosPersona {

    public void Insertar(Persona persona) {
        Statement s = null;
        String setencia = "insert into persona (cedula,nombre,apellidos,años) "
                + "values ('" + persona.cedula + "','" + persona.Nombre + "','" + persona.Apellidos
                + "','" + persona.años + "');";
        try {
            s = Conexion.getInstance().Conection.createStatement();//Se obtione la conexion de la clase Conexion
            s.execute(setencia);//Se ejecuta la consulta
        } catch (SQLException e) {
            Conexion.getInstance().isError = true;
            Conexion.getInstance().errorDescription = e.toString();
        }
    }

    public void Eliminar(int idpersona) {
        Statement s = null;
        String setencia = "delete from persona where id='" + idpersona + "'";
        try {
            s = Conexion.getInstance().Conection.createStatement();
            s.execute(setencia);
        } catch (SQLException e) {
            Conexion.getInstance().isError = true;
            Conexion.getInstance().errorDescription = e.toString();
        }
    }

    public void Modificar(Persona persona) {
        Statement s = null;
        String setencia = "update persona set cedula='" + persona.cedula
                + "',nombre='" + persona.Nombre
                + "',apellidos='" + persona.Apellidos
                + "',años='" + persona.años
                + "' where id='" + persona.id + "'";
        try {
            s = Conexion.getInstance().Conection.createStatement();
            s.executeUpdate(setencia);
        } catch (SQLException e) {
            Conexion.getInstance().isError = true;
            Conexion.getInstance().errorDescription = e.toString();
        }
    }

    public Persona OptenerPersona(int idpersona) {
        Persona persona = null;
        ResultSet rs = null;
        Statement s = null;
        String setencia = "";
        try {
            s = Conexion.getInstance().Conection.createStatement();
            setencia = "select *  from  persona where id='" + idpersona + "'";
            rs = s.executeQuery(setencia);
            persona = new Persona(Integer.parseInt(rs.getString("id")), rs.getString("cedula"), rs.getString("nombre"), rs.getString("apellidos"), Integer.parseInt(rs.getString("años")));
        } catch (Exception e) {
            Conexion.getInstance().isError = true;
            Conexion.getInstance().errorDescription = e.toString();
        }
        return persona;
    }

    public ArrayList<Persona> OptenerPersonas() {
        ArrayList<Persona> personas = new ArrayList<Persona>();
        ResultSet rs = null;
        Statement s = null;
        String setencia = "";
        try {
            s = Conexion.getInstance().Conection.createStatement();
            setencia = "select" + " * " + " from " + " persona ";
            rs = s.executeQuery(setencia);
            while (rs.next()) {
                //Se obtiene los datos del resulset 
                Persona persona = new Persona(Integer.parseInt(rs.getString("id")), rs.getString("cedula"), rs.getString("nombre"), rs.getString("apellidos"), Integer.parseInt(rs.getString("años")));
                personas.add(persona);
            }
        } catch (Exception e) {
            Conexion.getInstance().isError = true;
            Conexion.getInstance().errorDescription = e.toString();
        }
        return personas;
    }
}
