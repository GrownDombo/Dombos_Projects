# CPU & Memory Stress Test Tool

C++로 개발된 콘솔 기반 스트레스 테스트 도구입니다.  
멀티스레딩과 고부하 알고리즘을 통해 CPU 및 메모리의 성능과 안정성을 평가할 수 있도록 설계되었습니다.

처음에는 C# 기반으로 프로토타입을 작성했지만,  
C#의 특성상 GC(Garbage Collector)를 강제로 실행하더라도 메모리를 원하는 타이밍에 명확히 해제하는 것이 어렵다고 판단했습니다.  
따라서 더욱 정밀한 메모리 제어와 성능 측정을 위해 C++로 재작성하였습니다.

---

## 프로젝트 소개

이 프로젝트는 개발/테스트 환경에서 CPU 및 메모리의 성능을 **강제 부하를 통해 테스트**하기 위해 제작되었습니다.  
다양한 알고리즘을 활용한 **단일/병렬 처리 비교, 재귀, 수학 연산, 정렬, 망델브로 집합 계산, 메모리 대량 할당** 등을 지원합니다.

---

## ⚙️ 기능 요약

| 테스트 종류 | 설명 |
|-------------|------|
| 수학 연산 부하 | `pow`, `sin` 함수 사용하여 대규모 배열 계산 |
| 재귀 처리 부하 | 피보나치 수열 (깊이 45) 계산 |
| 소수 판별 부하 | 범위 내 모든 소수 탐색 (2 ~ 약 107M) |
| 정렬 테스트 | 랜덤 배열 정렬 및 병합 (최대 1000만 개) |
| 망델브로 계산 | 고해상도 복소수 망델브로 집합 계산 |
| 메모리 부하 테스트 | 물리 메모리의 80% 이상을 실시간으로 할당하고 접근 |

모든 테스트는 다음 두 가지 방식으로 비교 수행됩니다:
- `단일 처리` vs `멀티스레드 병렬 처리`
- `동일 작업 반복형` vs `작업 분담형` 병렬화

---

## 기술 스택
- **Language**: C++20  
- **Toolchain**: Visual Studio 2022  
- **API/Library**: WinAPI (`windows.h`, `psapi.h`, `shlobj.h`)  
- **기능 사용**: 멀티스레딩, 파일 시스템 처리, 고정밀 타이머, 실시간 메모리 제어, CSV 파일 출력

---

## 실행 결과

- 각 테스트 결과는 `CSV` 형식으로 저장되며, 데스크톱의 `/StressTestResult/YYYYMMDD_HHMMSS` 경로에 저장됩니다.
- CSV 파일에는 수행 시간(ms), 결과 데이터가 포함됩니다.

---

## 프로그램 흐름

1. 사용자로부터 반복 횟수 입력
2. 테스트 사이클 순차 실행 (총 11개 테스트)
3. 각 테스트는 다음을 수행:
   - 고부하 연산 수행
   - 시간 측정 및 결과 수집
   - CSV 파일로 결과 기록
4. 테스트 간 5초 대기 + 메모리 수동 정리

---

## 주요 설계 포인트

- `MaxArray<T>()`를 사용해 플랫폼별 최대 할당 배열 크기를 동적으로 계산
- `MeasureAndLog()`로 모든 작업에 대해 시간 측정 및 로깅 일원화
- `mutex`, `lock_guard`로 스레드 안전한 데이터 공유 처리
- WinAPI를 활용해 데스크톱 경로 및 시스템 메모리 상태 탐지
- 병렬 정렬 시 `chunk` 단위로 정렬 후 `merge`하는 병합 로직 직접 구현

---

## 테스트 예시 출력

```
[시작] [병렬 처리] 소수 찾기
[정보] 소수점 검색 범위 : 107374179, 소수점 개수 : 5731844
[결과] 소요 시간 : 12987.23 ms
[종료] [병렬 처리] 소수 찾기
```
<br><br>
---
<br><br>
# CPU & Memory Stress Test Tool (English)

A console-based CPU and memory stress testing tool written in C++.  
Designed to evaluate system performance and stability under high load using multithreading and heavy computation.

The initial prototype was developed in C#,  
but due to the nature of its Garbage Collector (GC), it was difficult to release memory precisely at desired points even with forced GC calls.  
To gain fine-grained control over memory and performance timing, the project was rewritten in C++.
---

## Project Overview

This project was developed to test CPU and memory performance in development or QA environments.  
It supports various high-load algorithms and comparisons such as **single-thread vs multithread**, **recursive processing**, **math-intensive workloads**, **sorting**, **Mandelbrot calculations**, and **large-scale memory allocation**.

---

## ⚙️ Key Features

| Test Type | Description |
|-----------|-------------|
| Math Load | Perform heavy array computations using `pow`, `sin` |
| Recursive Load | Fibonacci sequence with deep recursion (depth 45) |
| Prime Number Test | Scan and count primes in a large integer range |
| Sorting Test | Sort and merge large random arrays (up to 10M items) |
| Mandelbrot | High-res Mandelbrot set calculation |
| Memory Load | Allocate and access over 80% of physical memory in real time |

All tests are compared in:
- `Single-threaded` vs `Multi-threaded`
- `Repeating same task` vs `Divided workload` models

---

## Tech Stack

- **Language**: C++20  
- **Toolchain**: Visual Studio 2022  
- **API/Library**: WinAPI (`windows.h`, `psapi.h`, `shlobj.h`)  
- **Features**: Multithreading, file system ops, high-precision timers, memory diagnostics, CSV output

---

## Output Format

- Test results are saved in `CSV` format under the folder `/StressTestResult/YYYYMMDD_HHMMSS` on the desktop.
- Each CSV file contains duration in milliseconds and raw result data.

---

## Program Flow

1. Prompt user to input repeat count
2. Run stress cycle (11 test cases)
3. Each test performs:
   - CPU/memory stress task
   - Time measurement & result logging
   - Write results to CSV
4. 5-second wait and manual memory cleanup between tests

---

## Design Highlights

- Dynamic maximum array size detection via `MaxArray<T>()`
- Unified timing/logging via `MeasureAndLog()`
- Thread-safe data collection with `mutex` and `lock_guard`
- Desktop path & memory info via WinAPI
- Manual merge of sorted chunks for parallel sort

---

## Sample Output

```
[Start] [Parallel] Prime number search
[Info] Range: 107374179, Primes found: 5731844
[Time] Elapsed: 12987.23 ms
[End] [Parallel] Prime number search
```
