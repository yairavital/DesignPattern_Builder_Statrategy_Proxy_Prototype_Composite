using StrategyTirgull;

ITurnTrafficLights turnTraffic = new OnLight();
TrafficLightManagement trafficLightManagement = new TrafficLightManagement();
trafficLightManagement.Operate();