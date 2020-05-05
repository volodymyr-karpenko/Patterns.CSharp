import * as React from "react";
import { connect } from "react-redux";
import { Row, Col } from "react-bootstrap";
import { DropdownSelector } from "../../common/DropdownSelector";
import { PatternsOutput } from "./PatternsOutput";
import { patternsSlice } from "./patternsSlice";
import { IPatternsProps } from "./IPatternsProps";
import { IPatternsState } from "./IPatternsState";
import { PatternsData } from "./PatternsData";
import { store } from "../../app/store";
import { PatternsService } from "./PatternsService";

export class PatternsPage extends React.PureComponent<IPatternsProps> {

    constructor(props: IPatternsProps) {
        super(props);
        this.props = props;
    }

    public props: IPatternsProps;

    private PatternsData: PatternsData = new PatternsData();

    private PatternsService: PatternsService = new PatternsService();    

    render(): JSX.Element {

        return (

            <React.Fragment>
                <Row>
                    <Col>
                        <PatternsOutput {...this.props} />
                    </Col>
                </Row>         
                <Row className="flex-column align-items-center flex-md-row justify-content-md-between">
                    <Col className="col-auto mt-5">
                        <DropdownSelector
                            title={this.PatternsData.CreationalPatternsTitle}
                            options={this.PatternsData.CreationalPatterns}
                            onOptionClick={async (option) => {
                                const output: IPatternsState = await this.PatternsService.GetPatternOutputAsync(option);
                                this.props.presentOutput(output);
                            }} />
                    </Col>
                    <Col className="col-auto mt-5">
                        <DropdownSelector
                            title={this.PatternsData.StructuralPatternsTitle}
                            options={this.PatternsData.StructuralPatterns}
                            onOptionClick={async (option) => {
                                const output: IPatternsState = await this.PatternsService.GetPatternOutputAsync(option);
                                this.props.presentOutput(output);
                            }} />
                    </Col>
                    <Col className="col-auto mt-5">
                        <DropdownSelector
                            title={this.PatternsData.BehavioralPatternsTitle}
                            options={this.PatternsData.BehavioralPatterns}
                            onOptionClick={async (option) => {
                                const output: IPatternsState = await this.PatternsService.GetPatternOutputAsync(option);
                                this.props.presentOutput(output);
                            }} />
                    </Col>
                </Row>
            </React.Fragment>

        );
    }
}

export default connect(() => store.getState().patterns, patternsSlice.actions)(PatternsPage);