package com.example.ronal.androidapi;

import android.content.Context;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.TextView;

import com.android.volley.Request;
import com.android.volley.RequestQueue;
import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.android.volley.toolbox.HttpClientStack;
import com.android.volley.toolbox.StringRequest;
import com.android.volley.toolbox.Volley;


import Http.Server;
import Http.Http;

public class MainActivity extends AppCompatActivity {
    TextView textView;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        // Instantiate the RequestQueue.
        textView = (TextView) findViewById(R.id.txtMenu);
        Server.getInstance().useLaravel();
        //Http httpmethos = new Http();
        HttpGet(Server.getInstance().server + "airplanes", this);
        //textView.setText(httpmethos.resultGet);
    }

    public void HttpGet(String url, Context context) {
        RequestQueue queue = Volley.newRequestQueue(context);
        StringRequest stringRequest = new StringRequest(Request.Method.GET, url,
                new Response.Listener<String>() {
                    @Override
                    public void onResponse(String response) {
                        textView.setText(response.toString());
                    }
                }, new Response.ErrorListener() {
            @Override
            public void onErrorResponse(VolleyError error) {
                textView.setText("Ha ocurrido un error " + error.getMessage());
            }
        });
        queue.add(stringRequest);
    }
}
