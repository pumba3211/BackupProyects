package com.example.soporte.apicosuming;

import android.os.AsyncTask;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import org.json.JSONException;
import org.json.JSONObject;

import Estructuras.Dominio;
import JsonParser.JsonFabricante;
import ServerConection.Http;

public class NuevoFabricante extends AppCompatActivity implements View.OnClickListener {
    EditText txtnombre;
    EditText txtdireccion;
    EditText txttelefono;
    JSONObject jsonParam = new JSONObject();
    Button btnCrear;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_nuevo_fabricante);
        txtnombre = (EditText) findViewById(R.id.newFabrincanteNombre);
        txtdireccion = (EditText) findViewById(R.id.newFabrincanteDireccion);
        txttelefono = (EditText) findViewById(R.id.newFabrincanteTelefono);
        btnCrear = (Button) findViewById(R.id.button2);
        btnCrear.setOnClickListener(this);
    }

    @Override
    public void onClick(View v) {
        if (v.getId() == findViewById(R.id.button2).getId()) {
            executePost execute = new executePost();
            execute.execute();
        }
    }

    private class executePost extends AsyncTask<String, String, String> {
        protected String doInBackground(String... Url) {
            Http connect = new Http();
            String response = connect.HttpPost(Dominio.getInstance().Dominio + "fabricantes", Parametros(),"POST");
            JsonFabricante json = new JsonFabricante();
            return json.NuevoFabricante(response);
        }

        protected void onPostExecute(String result) {
            try {
                Toast.makeText(getBaseContext(), result, Toast.LENGTH_LONG).show();
            } catch (Exception e) {
                e.printStackTrace();
            }
        }

        public JSONObject Parametros() {
            try {
                jsonParam.put("nombre", txtnombre.getText());
                jsonParam.put("direccion", txtdireccion.getText());
                jsonParam.put("telefono", Integer.parseInt(txttelefono.getText().toString()));
            } catch (JSONException e) {
                e.printStackTrace();
            }
            return jsonParam;
        }
    }
}
