package home.learning.restdemo.service;

import org.springframework.stereotype.Service;

@Service
public class GreetingServiceImpl implements GreetingService {

	@Override
	public String sayHelloTosinglePerson(String name) {
		return "Hello, %s".formatted(name);
	}

	@Override
	public String sayHelloWorld() {
		return "Hello World!";
	}

}
