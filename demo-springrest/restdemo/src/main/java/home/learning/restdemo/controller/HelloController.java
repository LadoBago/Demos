package home.learning.restdemo.controller;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import home.learning.restdemo.service.GreetingService;

@RestController
@RequestMapping(path = "/hello")
public class HelloController {
	
	private final GreetingService greetingService;

	@Autowired
	public HelloController(GreetingService greetingService) {
		this.greetingService = greetingService;
	}

	@GetMapping
	public String get()	{
		
		return greetingService.sayHelloWorld();
		
	}

	@GetMapping(path="/{name}")
	public String get(@PathVariable("name") String name)	{
		
		return greetingService.sayHelloTosinglePerson(name);
		
	}
	
}
