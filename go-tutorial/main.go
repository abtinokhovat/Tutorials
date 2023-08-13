package main

import (
	"fmt"
	"net/http"
)

func getTextHandler(w http.ResponseWriter, r *http.Request) {
	text := "dmxlc3M6Ly9kY2E5ODU1NS0zYTM3LTQ5N2ItOWVlYi1hNTUxZWU2ZTQ1MGZAaXIuYmV0YTQubG93ZmFtaWxhLmNmZDozMjIwP3R5cGU9dGNwJnNlY3VyaXR5PW5vbmUmaGVhZGVyVHlwZT1odHRwJnBhdGg9JTJGJmhvc3Q9c3BlZWR0ZXN0Lm5ldCNAQVNUUk9fc2VydmVyQmV0YTQtbTE5amRlCnZsZXNzOi8vOGZmN2I1YjctMWU5Ni00ZmJjLTgzNDQtNGQ4OWM0MzRlYTMyQHZpcDEub2xkc2Nob29sLmNmZDoxNTUzMD90eXBlPXdzJnNlY3VyaXR5PW5vbmUmcGF0aD0lMkYjQEFTVFJPX3NlcnZlclZJUDEtMTAx"
	fmt.Fprintf(w, text)
	fmt.Println("Sent to", ReadUserIP(r))
}

func ReadUserIP(r *http.Request) string {
	IPAddress := r.Header.Get("X-Real-Ip")
	if IPAddress == "" {
		IPAddress = r.Header.Get("X-Forwarded-For")
	}
	if IPAddress == "" {
		IPAddress = r.RemoteAddr
	}
	return IPAddress
}

func main() {
	http.HandleFunc("/", getTextHandler)

	port := "8080"
	fmt.Printf("Server running on port %s...\n", port)
	err := http.ListenAndServe(":"+port, nil)
	if err != nil {
		panic(err)
	}

}
