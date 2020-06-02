package Estructures;

/**
 * Created by ronald on 28/12/16.
 */

public class Destination {
    public String name;
    public String description;

    public Destination(String description, String name) {
        this.description = description;
        this.name = name;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getDescription() {
        return description;
    }

    public void setDescription(String description) {
        this.description = description;
    }
}
