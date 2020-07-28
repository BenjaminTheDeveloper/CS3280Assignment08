# CS3280Assignment08
	Implementing the Bridge Design Pattern from the 23 GoF Patterns
	Coded: Benjamin Medrano 

#Summary 
	The bridge design patterns comes as a structural pattrern and decouples the implementation class and abstract class by connecting them as a bridge. 
	There is an interface that creates the bridge between the to independent classes. It allows for both classes to be changed without affecting the others structure. 

#Code 

	Implementor Class 
	public abstract class VehicleDataObject
	 
	This is implemented into the Vehicle data class as an interface or to use inheritance. 
	
	The Concrete Implementor 
	public class VehicleData : VehicleDataObject
	
	This is used as the data side to the Vehicle Base class


	The Abstraction Class 
	public class VehicleBase
	
	This is the base class to the vehicle class and contains all of the methods used throughout the Vehicles() object.

	
	The RefinedAbstractionClass 
	public class Vehicles : VehicleBase
	
	This is the object that is used to run the whole program 
	The class it self is bridged in a way that can add more vehicles, remove vehicles, get the count, mock the city that they come from, and show all the records contained within. 