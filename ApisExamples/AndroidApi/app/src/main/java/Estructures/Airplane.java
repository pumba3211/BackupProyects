package Estructures;

/**
 * Created by ronald on 28/12/16.
 */

public class Airplane {
    public String name;
    public Integer flying_hours;

    public Airplane(String name, Integer flying_hours) {
        this.name = name;
        this.flying_hours = flying_hours;
    }

    public void setName(String name) {
        this.name = name;
    }

    public void setFlying_hours(Integer flying_hours) {
        this.flying_hours = flying_hours;
    }

    public String getName() {
        return this.name;
    }

    public Integer getFlying_hours() {
        return this.flying_hours;
    }
}
