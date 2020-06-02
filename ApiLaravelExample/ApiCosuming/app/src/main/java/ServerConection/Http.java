package ServerConection;

import org.json.JSONObject;

import java.io.BufferedReader;
import java.io.DataOutputStream;
import java.io.IOException;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.MalformedURLException;
import java.net.URL;

/**
 * Created by soporte on 06/07/2016.
 */
public class Http {

    public String HttpGet(String getUrl) {
        HttpURLConnection connection = null;
        String result = null;
        try {
            StringBuilder content = new StringBuilder();
            URL url = new URL(getUrl);
            connection = (HttpURLConnection) url.openConnection();
            BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(connection.getInputStream()));
            String line;
            while ((line = bufferedReader.readLine()) != null) {
                content.append(line);
            }
            bufferedReader.close();
            result = content.toString();
        } catch (MalformedURLException e) {
            result = e.toString();
        } catch (IOException e) {
            result = e.toString();
        } finally {
            if (connection != null) {
                connection.disconnect();
            }
        }
        return result;
    }

    public String HttpPost(String postUrl, JSONObject jsonParam,String Method) {
        HttpURLConnection connection = null;
        String result = null;
        try {
            StringBuilder content = new StringBuilder();
            URL url = new URL(postUrl);
            connection = (HttpURLConnection) url.openConnection();
            connection.setDoOutput(true);
            connection.setDoInput(true);
            connection.setInstanceFollowRedirects(false);
            connection.setRequestMethod(Method);
            connection.setRequestProperty("Content-Type", "application/json");
            connection.setRequestProperty("charset", "utf-8");
            connection.setUseCaches(false);
            DataOutputStream wr = new DataOutputStream(connection.getOutputStream());
            wr.writeBytes(jsonParam.toString());

            BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(connection.getInputStream()));
            String line;
            while ((line = bufferedReader.readLine()) != null) {
                content.append(line);
            }
            bufferedReader.close();
            wr.flush();
            wr.close();
            result = content.toString();
        } catch (MalformedURLException e) {
            result = e.toString();
        } catch (IOException e) {
            result = e.toString();
        } finally {
            if (connection != null) {
                connection.disconnect();
            }
        }
        return result;
    }
}
