import { IPatternsState } from "./IPatternsState";

export class PatternsService {

    public async GetPatternOutputAsync(pattern: string): Promise<IPatternsState> {
        const id = pattern.replace(/ /g, "");
        let newState: IPatternsState = { SelectedPatternName: pattern, SelectedPatternOutput: "" };
        let response = await fetch("https://localhost:44348/api/patterns/getoutput", {
            method: "POST",
            headers: {
                "Content-Type": "application/json"
            },
            body: JSON.stringify({ patternType: id })
        });

        let responseText: string = await response.text();        

        newState.SelectedPatternOutput = responseText;

        return newState;
    }    
}