import xml.etree.ElementTree as ET

def parse_trx(trx_file):
    tree = ET.parse(trx_file)
    root = tree.getroot()

    passed = failed = skipped = 0

    for test_result in root.findall('.//TestResult'):
        outcome = test_result.get('outcome')
        if outcome == 'Passed':
            passed += 1
        elif outcome == 'Failed':
            failed += 1
        elif outcome == 'Skipped':
            skipped += 1

    report = f"""
    <html>
    <head><title>Test Report</title></head>
    <body>
    <h1>Test Results</h1>
    <p>Passed: {passed}</p>
    <p>Failed: {failed}</p>
    <p>Skipped: {skipped}</p>
    </body>
    </html>
    """
    return report

trx_file = 'test-results/test-results.trx'
html_report = parse_trx(trx_file)

with open('test-results.html', 'w') as f:
    f.write(html_report)
