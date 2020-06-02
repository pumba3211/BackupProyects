package JsonParser;

import android.app.VoiceInteractor;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import java.util.ArrayList;

import Estructuras.Aviones;
import Estructuras.Fabricante;

/**
 * Created by soporte on 06/07/2016.
 */
public class JsonFabricante {
    public ArrayList<Fabricante> obtenerFabricantes(String Info) {
        ArrayList<Fabricante> fabricantes = new ArrayList<>();
        try {
            JSONObject jsonRootObject = new JSONObject(Info);
            JSONArray errors = jsonRootObject.optJSONArray("errors");
            if (errors != null) {
            } else {
                //Get the instance of JSONArray that contains JSONObjects
                JSONArray jsonArray = jsonRootObject.optJSONArray("data");
                for (int i = 0; i < jsonArray.length(); i++) {
                    JSONObject jsonObject = jsonArray.getJSONObject(i);
                    Fabricante fabricante = new Fabricante(Integer.parseInt(jsonObject.optString("id").toString()), jsonObject.optString("nombre").toString(),
                            jsonObject.optString("direccion").toString(), Integer.parseInt(jsonObject.optString("telefono").toString()));
                    fabricantes.add(fabricante);
                }
            }
        } catch (JSONException e) {
            e.printStackTrace();
        }
        return fabricantes;
    }

    public Fabricante obtenerFabricante(String Info) {
        Fabricante fabricante = null;
        try {
            JSONObject jsonRootObject = new JSONObject(Info);
            JSONArray errors = jsonRootObject.optJSONArray("errors");
            ArrayList<Aviones> ListAviones= new ArrayList<>();
            if (errors != null) {
            } else {
                JSONObject jsonObject =  jsonRootObject.getJSONObject("data");
                fabricante = new Fabricante(Integer.parseInt(jsonObject.optString("id").toString()), jsonObject.optString("nombre").toString(),
                        jsonObject.optString("direccion").toString(), Integer.parseInt(jsonObject.optString("telefono").toString()));
                JSONArray jsonAviones = jsonObject.getJSONArray("aviones");
                for (int i = 0; i < jsonAviones.length(); i++) {
                    JSONObject jsonAvion = jsonAviones.getJSONObject(i);
                    Aviones avion = new Aviones(Integer.parseInt(jsonAvion.getString("serie")),
                            jsonAvion.getString("modelo"), Float.parseFloat(jsonAvion.getString("longitud")),
                            Integer.parseInt(jsonAvion.getString("capacidad")), Integer.parseInt(jsonAvion.getString("velocidad")),
                            Integer.parseInt(jsonAvion.getString("alcance")), Integer.parseInt(jsonAvion.getString("fabricante_id"))
                    );
                    ListAviones.add(avion);
                }
                fabricante.setAviones(ListAviones);
            }
        } catch (JSONException e) {
            e.printStackTrace();
        }
        return fabricante;
    }

    public String NuevoFabricante(String Info) {
        String resultado = "";
        try {
            JSONObject jsonRootObject = new JSONObject(Info);
            JSONArray errors = jsonRootObject.optJSONArray("errors");
            if (errors != null) {
                resultado = errors.getJSONObject(0).getString("message");
            } else {
                resultado = "Fabricante creado correctamente";
            }
        } catch (JSONException e) {
            e.printStackTrace();
        }
        return resultado;
    }
}
