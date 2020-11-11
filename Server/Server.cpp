

#include <iostream>
#include <WinSock2.h>
#pragma comment(lib,"ws2_32")

#define PORT 1234
#define PACKET_SIZE 1024


using namespace std;

int main()
{
	WSADATA wsaData;
	WSAStartup(MAKEWORD(2, 2), &wsaData);	// Window의 소켓 초기화 정보를 저장하기 위한 구조체

	SOCKET hListen;
	hListen = socket(PF_INET, SOCK_STREAM, IPPROTO_TCP); // 소켓(핸들) 생성

	SOCKADDR_IN tListenAddr = {};
	tListenAddr.sin_family = AF_INET;
	tListenAddr.sin_port = htons(PORT);
	tListenAddr.sin_addr.s_addr = htonl(INADDR_ANY); //  소켓의 구성요소를 담을 구조체 생성 및 값 ( IP,포트, )

	
	

	bind(hListen, (SOCKADDR*)&tListenAddr, sizeof(tListenAddr));
	listen(hListen, SOMAXCONN);  // Listen

	cout << "클라이언트 연결 대기중..." << endl;

	SOCKADDR_IN tClientAddr = {};
	int iClientSize = sizeof(tClientAddr);
	SOCKET hClient = accept(hListen, (SOCKADDR*)&tClientAddr, &iClientSize);	// Client 에서 접속할때까지 대기

	cout << "클라이언트 연결 성공!" << endl;

	while (1)
	{
		char cBuffer[PACKET_SIZE] = {};
		recv(hClient, cBuffer, PACKET_SIZE, 0);
		cout << cBuffer;	// 수신

		if (!strcmp(cBuffer, "end"))
			break;
	}


	closesocket(hClient);
	closesocket(hListen);


	WSACleanup();
}