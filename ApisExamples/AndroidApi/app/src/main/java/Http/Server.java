package Http;

/**
 * Created by ronald on 28/12/16.
 */

public class Server {
    public String laravel = "http://192.168.1.114:8000/";
    public String rails = "http://localhost:3000/";
    public String server;
    public void useLaravel() {
        server = laravel;
    }

    public void useRails() {

    }
    private static Server INSTANCE = new Server();//Se utiliza para asignar la conexion a la base de datos de manera global

    private Server() {
    }

    public static Server getInstance() {//Se obtiene la conexion global
        return INSTANCE;
    }

}
