import org.junit.jupiter.api.Disabled;
import org.junit.jupiter.api.DisplayName;
import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.*;

class BillForElectricityTest {

    @Test
    @DisplayName("Sum test 1")
    void sum(){
        assertEquals( 20.432, Calculations.billCalc(4,5.108));
    }
    @Test
    @DisplayName("Sum test 2")
    void sum2(){
        assertEquals( 1317.8639999999998, Calculations.billCalc(258,5.108));
    }
}