int RED_LED = D7;
int GREEN_LED = D3;

void setup()
{
    pinMode(RED_LED, OUTPUT);
    pinMode(GREEN_LED, OUTPUT);
    
    Particle.function("redled", red_change);
    Particle.function("greenled", green_change);
    
    digitalWrite(RED_LED, LOW);
    digitalWrite(GREEN_LED, LOW);
}

void loop()
{
    
}


int red_change(String red)
{
    if(red == "on")
    {
        digitalWrite(RED_LED, HIGH);
        return 1;
        
    }else if(red=="off")
    {
        digitalWrite(RED_LED, LOW);
        return 0;
    }else
    {
        return -1;
    }
    
}

int green_change(String green)
{
    if(green =="on")
    {
        digitalWrite(GREEN_LED, HIGH);
        return 1;
        
    }else if(green =="off")
    {
        digitalWrite(GREEN_LED, LOW);
        return 0; 
    }
    else
    {
        return -1;
    }
}

