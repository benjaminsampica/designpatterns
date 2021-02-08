using System;

namespace FacadePattern
{
    public class HomeTheaterFacade
    {
        private readonly Amplifier _amp;
        private readonly Tuner _tuner;
        private readonly DvdPlayer _dvdPlayer;
        private readonly Projector _projector;
        private readonly TheaterLights _theaterLights;

        public HomeTheaterFacade(Amplifier amp, Tuner tuner, DvdPlayer dvdPlayer, Projector projector, TheaterLights theaterLights)
        {
            _amp = amp;
            _tuner = tuner;
            _dvdPlayer = dvdPlayer;
            _projector = projector;
            _theaterLights = theaterLights;
        }

        public void TurnOn()
        {
            _amp.On();
            _tuner.On();
            _dvdPlayer.On();
            _projector.On();
            _theaterLights.On();
        }
    }

    public class Amplifier
    {
        public void On()
        {
            throw new NotImplementedException();
        }
    }

    public class Tuner
    {
        public void On()
        {
            throw new NotImplementedException();
        }
    }

    public class DvdPlayer
    {
        public void On()
        {
            throw new NotImplementedException();
        }
    }

    public class Projector
    {
        public void On()
        {
            throw new NotImplementedException();
        }
    }

    public class TheaterLights
    {
        public void On()
        {
            throw new NotImplementedException();
        }
    }
}
