package Estructures;

/**
 * Created by ronald on 28/12/16.
 */

public class Pilot {
    public String license;
    public String name;
    public int flying_hours;

    public Pilot(String license, String name, int flying_hours) {
        this.license = license;
        this.name = name;
        this.flying_hours = flying_hours;
    }

    public String getLicense() {
        return license;
    }

    public void setLicense(String license) {
        this.license = license;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public int getFlying_hours() {
        return flying_hours;
    }

    public void setFlying_hours(int flying_hours) {
        this.flying_hours = flying_hours;
    }
}
