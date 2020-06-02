package Estructures;

import java.util.Date;
import java.util.List;

/**
 * Created by ronald on 28/12/16.
 */

public class Programming {
    public Date star;
    public Date end;
    public Airplane airplane;
    public Destination destination;
    public Pilot pilot;

    public Programming(Date star, Date end, Airplane airplane, Destination destination, Pilot pilot) {
        this.star = star;
        this.end = end;
        this.airplane = airplane;
        this.destination = destination;
        this.pilot = pilot;
    }

    public Date getStar() {
        return star;
    }

    public void setStar(Date star) {
        this.star = star;
    }

    public Date getEnd() {
        return end;
    }

    public void setEnd(Date end) {
        this.end = end;
    }

    public Airplane getAirplane() {
        return airplane;
    }

    public void setAirplane(Airplane airplane) {
        this.airplane = airplane;
    }

    public Destination getDestination() {
        return destination;
    }

    public void setDestination(Destination destination) {
        this.destination = destination;
    }

    public Pilot getPilot() {
        return pilot;
    }

    public void setPilot(Pilot pilot) {
        this.pilot = pilot;
    }
}
