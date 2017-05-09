import com.leapmotion.leap.*;
import com.sun.org.apache.xpath.internal.SourceTree;

import java.io.IOException;

public class Main {

    public static void main(String[] args) {
        // Create a sample listener and controller
        SampleListener listener = new SampleListener();
        Controller controller = new Controller();

        controller.addListener(listener);

        // Keep this process running until Enter is pressed
        System.out.println("Press Enter to quit...");
        try {
            System.in.read();
        } catch (IOException e) {
            e.printStackTrace();
        }

        // Remove the sample listener when done
        controller.removeListener(listener);

    }
}

class SampleListener extends Listener {

    public void onConnect(Controller controller) {
        System.out.println("Connected");
    }

    public void onFrame(Controller controller) {
        Frame frame = controller.frame();
        Hand hand = frame.hands().rightmost();
        Matrix basis = hand.basis();
        float speed = basis.getZBasis().getY();
        Vector handCenter = hand.palmPosition();
        float direction_left_right = handCenter.getX();
        float direction_front_back = handCenter.getZ();
        System.out.println(direction_front_back);
    }
}